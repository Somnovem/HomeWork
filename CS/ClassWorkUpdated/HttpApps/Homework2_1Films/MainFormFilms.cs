using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Homework2_1Films
{
    public partial class MainFormFilms : Form
    {
        private string apiKey = "8081947b";
        public MainFormFilms()
        {
            InitializeComponent();
            MailSender.SendingResult += MailSender_SendingResult;
        }

        private void MailSender_SendingResult(string message)
        {
            MessageBox.Show(message);
            Action a = () => { btnSendMail.Enabled = true; };
            if (InvokeRequired) Invoke(a);
            else a();
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            btnGetInfo.Enabled = false;
            string url = $"http://www.omdbapi.com/?t={edTitle.Text}&apikey={apiKey}";
            WebClient webClient = new WebClient();
            byte[] data = null;
            data = webClient.DownloadData(url);

            
            string response = Encoding.UTF8.GetString(data);
            dynamic filminfo = JsonConvert.DeserializeObject<dynamic>(response);
            string poster = "";
            try
            {
                poster = filminfo.Poster.ToString();
            }
            catch
            {
                MessageBox.Show("No such film found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGetInfo.Enabled = true;
                return;
            }
            var title = filminfo.Title;
            var year = filminfo.Year;
            var rated = filminfo.Rated;
            var released = filminfo.Released;
            var runtime = filminfo.Runtime;
            var genre = filminfo.Genre;
            var director = filminfo.Director;
            var actors = filminfo.Actors;
            var metascore = filminfo.Metascore;
            var imdbRating = filminfo.imdbRating;
            var boxOffice = filminfo.BoxOffice;

            

            WebClient client = new WebClient();
            byte[] imageData = client.DownloadData(poster);
            MemoryStream stream = new MemoryStream(imageData);
            pbPoster.Image = System.Drawing.Image.FromStream(stream, true, true);

            lblInfo.Text = $"Title: {title}\n" +
                           $"Year: {year}\n" +
                           $"Rated: {rated}\n" +
                           $"Released on: {released}\n" +
                           $"Runtime: {runtime}\n" +
                           $"Genre: {genre}\n" +
                           $"Director(s): {director}\n" +
                           $"Actors: {actors}\n" +
                           $"Metascore: {metascore}\n" +
                           $"IMDB Rating: {imdbRating}\n" +
                           $"Box office: {boxOffice}";
            btnGetInfo.Enabled = true;
            if(!btnSendMail.Enabled)btnSendMail.Enabled = true;
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            MailSender.SendFilmInfo(edSenderMail.Text, edReceiverEmail.Text, edPassword.Text, "Film info", edBody.Text,lblInfo.Text);
            btnSendMail.Enabled = false;
        }
    }
}
