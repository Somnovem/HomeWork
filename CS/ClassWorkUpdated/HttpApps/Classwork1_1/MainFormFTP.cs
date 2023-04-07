using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork1_1
{
    public partial class MainFormFTP : Form
    {
        private List<FtpItem> ftpItems;
        private SaveFileDialog saveFile;
        //в основном использует 21 порт
        public MainFormFTP()
        {
            ftpItems = new List<FtpItem>();
            saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            InitializeComponent();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(edAddress.Text);
            //request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            request.EnableSsl = cbUseSsl.Checked;
            if (!!string.IsNullOrEmpty(edLogin.Text) && !string.IsNullOrEmpty(edPassword.Text))
            {
                request.Credentials = new NetworkCredential(edLogin.Text, edPassword.Text);
            }
            lbFiles.Items.Clear();
            ftpItems.Clear();
            try
            {
                FtpWebResponse response = (FtpWebResponse)(await request.GetResponseAsync());
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string line;
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    FtpItem ftpItem = new FtpItem(line);
                    ftpItems.Add(ftpItem);
                    lbFiles.Items.Add(ftpItem);
                }
                reader.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                btnConnect.Enabled = true;
            }
        }

        private async void lbFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbFiles.SelectedIndex == ListBox.NoMatches) return;
            int id = lbFiles.SelectedIndex;
            FtpItem item = ftpItems[id];
            saveFile.FileName = item.ShortPath;
            if (item.IsDirectory)
            {
                edAddress.Text = $"{edAddress.Text}/{item.ShortPath}/";
                btnConnect_Click(null, null);
            }
            else
            {
                if (saveFile.ShowDialog() != DialogResult.OK) return;
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"{edAddress.Text}/{item.ShortPath}");
                //request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.EnableSsl = cbUseSsl.Checked;
                if (!!string.IsNullOrEmpty(edLogin.Text) && !string.IsNullOrEmpty(edPassword.Text))
                {
                    request.Credentials = new NetworkCredential(edLogin.Text, edPassword.Text);
                }
                lbFiles.Enabled = false;
                btnConnect.Enabled = false;
                try
                {
                    FtpWebResponse response = (FtpWebResponse)(await request.GetResponseAsync());
                    Stream stream = response.GetResponseStream();
                    FileStream file = (FileStream)saveFile.OpenFile();
                    
                    await stream.CopyToAsync(file);
                    //byte[] data = new byte[1024];
                    //int size;
                    //while ((size = stream.Read(data,0,data.Length)) > 0)
                    //{
                    //    await file.WriteAsync(data, 0, data.Length);
                    //}
                    //await file.FlushAsync();

                    file.Close();
                    stream.Close();
                    response.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    btnConnect.Enabled = true;
                    lbFiles.Enabled = true;
                }
            }
        }
    }
}
