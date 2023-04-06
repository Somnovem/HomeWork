using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace LanApp9_2SMTP
{
    public partial class MainFormSMTP : Form
    {
        public MainFormSMTP()
        {
            InitializeComponent();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            MailAddress fromAddress = new MailAddress(edSenderMail.Text);//от
            MailAddress toAddress = new MailAddress(edReceiverMail.Text);//до

            MailMessage message = new MailMessage(fromAddress,toAddress);//инициализация сообщения
            message.Subject = edSubject.Text;//тема
            message.Body = edContent.Text;//контент
            message.IsBodyHtml = cbIsHtml.Checked;//внутренность - html

            SmtpClient smtp = new SmtpClient(edServerMail.Text, (int)edServerPort.Value);//создаем связь с смтп клиентом
            smtp.EnableSsl = true;//зачастую нужен всем серверам для безопасности данных пакетов
            smtp.Credentials = new NetworkCredential(edSenderMail.Text, edSenderPassword.Text);//предоставить логин пароль

            try
            {
                await smtp.SendMailAsync(message); //можно и синхронно - smtp.Send(message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally 
            {
                btnSend.Enabled = true;
            }
        }
    }
}
