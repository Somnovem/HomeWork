using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Homework2_1Weather
{
    public partial class MainFormWeather : Form
    {
        private string weatherAPIKey = "7ccd5870232a435d72577db422ec6b7f";
        private static Dictionary<string, Image> weatherImages;
        private List<WeatherDailyReport> weatherReports;
        public MainFormWeather()
        {
            if (weatherImages == null) FillWeatherImages();
            InitializeComponent();
            weatherReports = new List<WeatherDailyReport>();
        }

        private void FillWeatherImages()
        {
            weatherImages = new Dictionary<string, Image>();
            weatherImages.Add("Clear", Image.FromFile(@"..\..\Images\clear.png"));
            weatherImages.Add("Rain", Image.FromFile(@"..\..\Images\rain.png"));
            weatherImages.Add("Snow", Image.FromFile(@"..\..\Images\snow.png"));
            weatherImages.Add("Clouds", Image.FromFile(@"..\..\Images\cloud.png"));
            weatherImages.Add("Haze", Image.FromFile(@"..\..\Images\mist.png"));
        }

        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edCity.Text))
            {
                MessageBox.Show("No city's name entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            byte[] data = null;
            string weatherUrl = $"https://api.openweathermap.org/data/2.5/forecast?q={edCity.Text}&appid={weatherAPIKey}&units=metric";
            WebClient webClient = new WebClient();
            try
            {
                data = webClient.DownloadData(weatherUrl);
            }
            catch
            {
                MessageBox.Show("No such city found!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            weatherReports.Clear();
            lbDays.Items.Clear();
            string response = Encoding.UTF8.GetString(data);
            dynamic forecast = JsonConvert.DeserializeObject<dynamic>(response);
            JArray list = forecast["list"];
            foreach (var item in list)
            {
                var desctiption = (string)item["weather"][0]["description"];
                var temperature = (double)item["main"]["temp"];
                var feels_like = (double)item["main"]["feels_like"];
                var humidity = (int)item["main"]["humidity"];
                var pressure = (int)item["main"]["pressure"];
                var windSpeed = (double)item["wind"]["speed"];
                WeatherDailyReport report = new WeatherDailyReport()
                {
                    Description = $"Description: {desctiption}\n" +
                              $"Temperature: {temperature} Celsius\n" +
                              $"Feels like: {feels_like} Celsius\n" +
                              $"Air pressure: {pressure} mmHg\n" +
                              $"Speed of wind: {windSpeed} km\\h\n" +
                              $"Humidity: {humidity} %",
                    Image = weatherImages[item["weather"][0]["main"].ToString()]
                };
                weatherReports.Add(report);
            }
            for (int i = 0; i < 5; i++)
            {
                lbDays.Items.Add(DateTime.Now.AddDays(i).DayOfWeek);
            }
        }

        private void lbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDays.SelectedItem == null) return;
            lblWeather.Text = weatherReports[lbDays.SelectedIndex].Description;
            pbWeather.Image = weatherReports[lbDays.SelectedIndex].Image;
        }
    }

    public class WeatherDailyReport
    {
        public Image Image { get; set; }
        public string Description { get; set; }
    }
}
