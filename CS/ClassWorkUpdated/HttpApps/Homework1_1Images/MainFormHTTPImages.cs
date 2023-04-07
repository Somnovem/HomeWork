using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Collections.Generic;
using Image = System.Drawing.Image;
using System.Threading.Tasks;
using System.Threading;

namespace Homework1_1Images
{
    public partial class MainFormHTTPImages : Form
    {
        private ushort curImgGoogleIndex;
        private ushort curImgBingIndex;
        private RequestHandler requestHandler;
        public MainFormHTTPImages()
        {
            InitializeComponent();
            curImgGoogleIndex = 0;
            curImgBingIndex = 0;

            googleImages.ImageSize = new Size(256, 256);
            bingImages.ImageSize = new Size(256, 256);
            googleImages.ColorDepth = ColorDepth.Depth32Bit;
            bingImages.ColorDepth = ColorDepth.Depth32Bit;

            requestHandler = new RequestHandler();
            requestHandler.GoogleImagesGathered += RequestHandler_GoogleImagesGathered;
            requestHandler.BingImagesGathered += RequestHandler_BingImagesGathered;
            requestHandler.AllRequestsFulfilled += RequestHandler_AllRequestsFulfilled;
        }

        private void RequestHandler_AllRequestsFulfilled()
        {
            InvokeAction(() => { btnSendRequest.Enabled = true; });
        }

        private void RequestHandler_BingImagesGathered(List<Image> obj)
        {
            InvokeAction(() =>
            {
                bingImages.Images.AddRange(obj.ToArray());
                pbBing.Image = bingImages.Images[0];
                curImgBingIndex = 0;
            });
        }

        private void RequestHandler_GoogleImagesGathered(List<Image> obj)
        {
            InvokeAction(() =>
            {
                googleImages.Images.AddRange(obj.ToArray());
                pbGoogle.Image = googleImages.Images[0];
                curImgGoogleIndex = 0;
            });
        }

        public void InvokeAction(Action a)
        {
            if (InvokeRequired) Invoke(a);
            else a();
        }


        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            string request = edRequest.Text;
            if (string.IsNullOrEmpty(request))
            {
                MessageBox.Show("Request is empty");
                return;
            }
            if (!cbUseBing.Checked && !cbUseGoogle.Checked)
            {
                MessageBox.Show("No search engines selected");
                return;
            }
            btnSendRequest.Enabled = false;
            if (cbUseGoogle.Checked)
            {
                googleImages.Images.Clear();
                string googleRequestUrl = $"https://www.google.com/search?q={request}";
                browserGoogle.Navigate(googleRequestUrl);
                requestHandler.GoogleRequestAsync(googleRequestUrl);
            }
            if (cbUseBing.Checked)
            {
                bingImages.Images.Clear();
                string bingRequestUrl = $"https://www.bing.com/search?q={request}";
                browserBing.Navigate(bingRequestUrl);
                requestHandler.BingRequestAsync(bingRequestUrl);
            }
        }

        private void btnGoogleBack_Click(object sender, EventArgs e)
        {
            if (curImgGoogleIndex == 0) return;
            curImgGoogleIndex--;
            pbGoogle.Image = googleImages.Images[curImgGoogleIndex];
        }

        private void btnGoogleNext_Click(object sender, EventArgs e)
        {
            if (curImgGoogleIndex == googleImages.Images.Count - 1) return;
            curImgGoogleIndex++;
            pbGoogle.Image = googleImages.Images[curImgGoogleIndex];
        }

        private void btnBingBack_Click(object sender, EventArgs e)
        {
            if (curImgBingIndex == 0) return;
            curImgBingIndex--;
            pbBing.Image = bingImages.Images[curImgBingIndex];
        }

        private void btnBingNext_Click(object sender, EventArgs e)
        {
            if (curImgBingIndex == bingImages.Images.Count - 1) return;
            curImgBingIndex++;
            pbBing.Image = bingImages.Images[curImgBingIndex];
        }
    }

    public class RequestHandler 
    {
        private int aliveRequests;


        public RequestHandler()
        {
            aliveRequests = 0;
        }


        public event Action<List<Image>> GoogleImagesGathered;
        public event Action<List<Image>> BingImagesGathered;
        public event Action AllRequestsFulfilled;


        private void CheckState()
        {
            if (aliveRequests == 0) AllRequestsFulfilled?.Invoke();
        }
        private Image DownoloadImage(string src)
        {
            WebClient client = new WebClient();
            byte[] imageData = client.DownloadData(src);
            MemoryStream stream = new MemoryStream(imageData);
            return Image.FromStream(stream, true, true);
        }


        public void GoogleRequest(string request)
        {
           Interlocked.Increment(ref aliveRequests);
           string urlimages = request + "&tbm=isch&tbs=isz:l";
           HtmlWeb web = new HtmlWeb();
           HtmlAgilityPack.HtmlDocument doc = web.Load(urlimages);
           HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//img");
           string[] attrs = { "src", "data-src", "data-iurl", "data-deferred-src" };
           List<Image> images = new List<Image>();
           foreach (HtmlNode node in nodes)
           {
               string src = null;
               foreach (string attr in attrs)
               {
                   src = node.GetAttributeValue(attr, null);
                   if (src != null)
                   {
                       break;
                   }
               }

               if (src != null)
               {
                   images.Add(DownoloadImage(src));
               }
           }
           GoogleImagesGathered?.Invoke(images);
           Interlocked.Decrement(ref aliveRequests);
           CheckState();
        }
        public void GoogleRequestAsync(string request) => Task.Run(() => { GoogleRequest(request); });
        public void BingRequest(string request)
        {
            Interlocked.Increment(ref aliveRequests);
            string imageUrl = request.Insert(request.LastIndexOf(".com") + 4, "/images") + "&form=HDRSC2&first=1&tsc=ImageBasicHover";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(imageUrl);
            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//img[@data-src]");
            List<Image> images = new List<Image>();
            foreach (HtmlNode node in nodes)
            {
                string src = node.GetAttributeValue("data-src", null);
                if (src != null)
                {
                    try
                    {
                        images.Add(DownoloadImage(src));
                    }
                    catch
                    {
                    }

                }
            }
            BingImagesGathered?.Invoke(images);
            Interlocked.Decrement(ref aliveRequests);
            CheckState();
        }
        public void BingRequestAsync(string request) => Task.Run(() => { BingRequest(request); });
    }
}
