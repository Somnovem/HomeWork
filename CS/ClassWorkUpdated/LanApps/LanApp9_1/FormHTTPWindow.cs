using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using System.Security.Policy;
using System.IO;
namespace LanApp9_1
{
    public partial class FormHTTPWindow : Form
    {
        
        //клиент для обработки запросов по протоколу HTTP
        private static HttpClient httpClient = new HttpClient();
        private bool isXmlSaved = false;
        public FormHTTPWindow()
        {
            InitializeComponent();
        }

        private async void btnHTTPLoad_Click(object sender, EventArgs e)
        {
            lbHeaders.Items.Clear();
            Uri uri = null;
            try
            {
                uri = new Uri(edHttpAdress.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error adress");
                return;
            }

            //для получения куки нужен контейнер
            CookieContainer cookieContainer = new CookieContainer();  

            //создает обьект отправляемого запроса
            using (HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get,uri))
            {
                //при нужде добавляем заголовки
                //httpRequestMessage.Headers.Add();
                httpRequestMessage.Headers.Add("User-Agent","Chrome/51.0.2704.103 Safari/537.26 (Windows NT 6.1; Win64; x64; rv:47.0)");
                using (HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage))
                {
                    lbHeaders.Items.Add($"StatusCode: {httpResponseMessage.StatusCode}");
                    lbHeaders.Items.Add($"ReasonPhrase: {httpResponseMessage.ReasonPhrase}");
                    lbHeaders.Items.Add($"IsSuccessStatusCode: {httpResponseMessage.IsSuccessStatusCode}");
                    lbHeaders.Items.Add("");

                    //обработка заголовков
                    lbHeaders.Items.Add("Headers");
                    lbHeaders.Items.Add("==============================================");
                    foreach (var item in httpResponseMessage.Headers)
                    {
                        lbHeaders.Items.Add(item.Key);
                        foreach (var value in item.Value)
                        {
                            lbHeaders.Items.Add($"    {value}");
                        }
                    }
                    lbHeaders.Items.Add("==============================================");

                    //заполнить контейнер куки
                    foreach (var item in httpResponseMessage.Headers.GetValues("Set-Cookie"))
                    {
                        cookieContainer.SetCookies(uri, item);
                    }
                    // отобразить cookie
                    lbHeaders.Items.Add("");
                    lbHeaders.Items.Add("Cookies");
                    lbHeaders.Items.Add("==============================================");
                    foreach (Cookie item in cookieContainer.GetCookies(uri))
                    {
                        lbHeaders.Items.Add($"{item.Name}: {item.Value} - {item.Domain}");
                    }
                    lbHeaders.Items.Add("==============================================");

                    //отображение ответа
                    edContent.Text = await httpResponseMessage.Content.ReadAsStringAsync();
                }
            }
        }

        private async void btnCurrencyLoad_Click(object sender, EventArgs e)
        {
            DateTime d= edCurrencyDate.Value;
            string sd = d.ToString("yyyy") + d.ToString("MM") + d.ToString("dd");
            Uri uriXml = new Uri($"https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?date={sd}");
            Uri uriJson = new Uri($"https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?date={sd}&json");
            Uri uri = isXmlSaved ? uriXml : uriJson; 
            using (HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri))
            {
                httpRequestMessage.Headers.Add("User-Agent", "Chrome/51.0.2704.103 Safari/537.26 (Windows NT 6.1; Win64; x64; rv:47.0)");
                using (HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage))
                {
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        edContent.Text = await httpResponseMessage.Content.ReadAsStringAsync();
                    }
                    
                }
            }
        }

        private void btnCurrencySave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = isXmlSaved ? "XML files|*.xml" : "JSON files|*.json";
            saveFileDialog.FileName = isXmlSaved ? "current.xml" : "current.json";
            saveFileDialog.AddExtension = true;
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            File.WriteAllText(saveFileDialog.FileName, edContent.Text,Encoding.Unicode);
        }

        private void rbXml_CheckedChanged(object sender, EventArgs e)
        {
            isXmlSaved = !isXmlSaved;
        }
    }
}
