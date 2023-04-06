using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.IO;

namespace LanApp7_1Web
{
    public partial class MainFormWebClient : Form
    {
        private WebClient webClient;
        private SaveFileDialog dlgSave;
        public MainFormWebClient()
        {
            webClient = new WebClient();
            dlgSave = new SaveFileDialog();
            
            InitializeComponent();
        }

        private void btnDownoloadFile_Click(object sender, EventArgs e)
        {
            
            dlgSave.InitialDirectory = @"c:\";
            downoloadProgressBar.Value = 0;
            if (dlgSave.ShowDialog() != DialogResult.OK) return;
            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
            webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
            webClient.DownloadFileAsync(new Uri(edFileAdress.Text),dlgSave.FileName);
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Action a = () => { downoloadProgressBar.Value = e.ProgressPercentage; };
            if (InvokeRequired) Invoke(a);
            else a();
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Downoload complete!");
        }

        private async void btnHTTPLoad_Click(object sender, EventArgs e)
        {
            lbHeaders.Items.Clear();
            //настройка запроса
            HttpWebRequest webRequest = HttpWebRequest.CreateHttp(edHttpAdress.Text);
            webRequest.Headers.Add("Content-Encoding", "utf-8");
            webRequest.CookieContainer = new CookieContainer();//будет заполнен при выполнении запроса
            try
            {
                //исполнение запроса
                using (HttpWebResponse httpWebResponse = (HttpWebResponse)await webRequest.GetResponseAsync())
                {
                    lbHeaders.Items.Add($"Status code: {httpWebResponse.StatusCode}"); //если код не 200, то произошла какая-то ошиббка и ответ скорее всего уже читать не нужно
                    string answer = httpWebResponse.StatusDescription;
                    if (string.IsNullOrEmpty(answer)) lbHeaders.Items.Add($"Status description: {answer}");
                    //читаем заголовки ответа
                    WebHeaderCollection headerCollection = httpWebResponse.Headers;
                    for (int i = 0; i < httpWebResponse.Headers.Count; i++)
                    {
                        lbHeaders.Items.Add(httpWebResponse.Headers[i]);
                    }

                    lbHeaders.Items.Add("=====================================================");
                    //смотрим на куки
                    foreach (Cookie cookie in httpWebResponse.Cookies)
                    {
                        lbHeaders.Items.Add($"{cookie.Name}: {cookie.Value} - {cookie.Domain}");
                    }

                    //чтение ответа
                    using (StreamReader reader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        edContent.Text = reader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
