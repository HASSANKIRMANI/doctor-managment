using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.IO;

namespace OOP_PROJECT_WINDOW_FORM
{
    public partial class EmailProgressing : Form
    {
        string emailAddress;
        string randomNumber;

        public EmailProgressing()
        {
            InitializeComponent();
        }

        public EmailProgressing(string emailAddress , string randomNumber)
        {
            this.emailAddress = emailAddress;
            this.randomNumber = randomNumber;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            string verfication = "Your Verification Code for Signing Up is \n\n";
            MailMessage mail = new MailMessage("no.reply.doctor.assistant@gmail.com",emailAddress, "Verification Code", verfication + randomNumber);
            SmtpClient Client = new SmtpClient("smtp.gmail.com");
            Client.Port = 587;
            Client.Credentials = new System.Net.NetworkCredential("no.reply.doctor.assistant@gmail.com", "doctor123patient");
            Client.EnableSsl = true;

            backgroundWorker1.ReportProgress(25);
            backgroundWorker1.ReportProgress(50);
            Client.Send(mail);
            backgroundWorker1.ReportProgress(75);
            Thread.Sleep(200);
            backgroundWorker1.ReportProgress(100);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Thread.Sleep(500);
            btnok.Enabled = true; 
            label1.Text = "Email Sent";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = " ";
            btnok.Enabled = false; 
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
