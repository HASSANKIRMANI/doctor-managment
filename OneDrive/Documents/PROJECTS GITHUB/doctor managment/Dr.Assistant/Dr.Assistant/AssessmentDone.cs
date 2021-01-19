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
    public partial class AssessmentDone : Form
    {

        string patient_username;
        string patient_path;

        public AssessmentDone()
        {
            InitializeComponent();
        }

        public AssessmentDone(string patient_path , string patient_username)
        {
            this.patient_path = patient_path;
            this.patient_username = patient_username;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = " ";
            if (!backgroundWorker1.IsBusy)
            {
                //call dowork function
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        void notifyPatient()
        {
            string emailAddress = null;

            StreamReader pa = null;

            try
            {
                pa = new StreamReader(patient_path + patient_username + ".txt");
            }
            catch { MessageBox.Show("Unable to Open File"); }

            for (int i = 0; i < 10; ++i)
                emailAddress = pa.ReadLine();

            pa.Close();

            string date = DateTime.Now.ToString();

            string appointment = "\n\n" + @"\\\*******Assessment Completed*******///" + "\n\n Date: " + date +
                "\n\n Note: The Doctor has completed your assessment and has written the prescription, kindly visit Dr.Assistant to view and print it";

            try
            {
                MailMessage mail = new MailMessage("no.reply.doctor.assistant@gmail.com", emailAddress, "Appointment Details", appointment);
                SmtpClient Client = new SmtpClient("smtp.gmail.com");
                Client.Port = 587;
                Client.Credentials = new System.Net.NetworkCredential("no.reply.doctor.assistant@gmail.com", "doctor123patient");
                Client.EnableSsl = true;
                Client.Send(mail);
            }
            catch
            {
                MessageBox.Show("Unable to Send Pin to this Email Id");
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(200);
            backgroundWorker1.ReportProgress(25);
            notifyPatient();
            backgroundWorker1.ReportProgress(50);
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

            label1.Text = "Notification Send to Patient";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
