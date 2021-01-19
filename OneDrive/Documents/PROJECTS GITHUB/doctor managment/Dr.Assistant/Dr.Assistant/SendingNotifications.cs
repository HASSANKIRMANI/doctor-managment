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
    public partial class SendingNotifications : Form , INotifyUsers
    {
        string username;
        string doc_path;
        string patient_path;
        doctor doc;
        public SendingNotifications()
        {
            InitializeComponent();
        }

        public SendingNotifications(string username, doctor doc)
        {
            doc_path = First_Page.doc_path;
            // doc_path =

            patient_path = First_Page.pat_path;
            // patient_path = 

            this.username = username;

            this.doc = doc;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }


        public void notifyPatient(doctor doc)
        {
            string emailAddress = null;

            StreamReader pa = null;

            try
            {
                pa = new StreamReader(patient_path + username + ".txt");
            }
            catch { MessageBox.Show("Unable to Open File"); }

            for (int i = 0; i < 10; ++i)
                emailAddress = pa.ReadLine();

            pa.Close();

            string date = DateTime.Now.ToString();

            string appointment = "\n\n####-------Doctor's Info-------#### \n\n Date: " + date + "\n\n\nName: " + doc._FirstName + " " + doc._LastName +
                "\n\nAge: " + doc._Age + "\n\nSpeciality: " + doc._Speciality + "\n\nFee: " + doc._Fee;

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

        public void notifyDoctor(doctor doc)
        {
            string emailAddress = null;

            StreamReader dr = null;
            StreamReader pa = null;

            try
            {
                dr = new StreamReader(doc_path + doc._Username + ".txt");
                pa = new StreamReader(patient_path + username + ".txt");
            }
            catch { MessageBox.Show("Unable to Open File"); }

            for (int i = 0; i < 13; ++i)
                emailAddress = dr.ReadLine();

            dr.Close();

            Patient patient = new Patient();

            patient._FirstName = pa.ReadLine();
            patient._LastName = pa.ReadLine();
            for (int i = 0; i < 2; ++i)
                pa.ReadLine();
            patient._Age = Int32.Parse(pa.ReadLine());
            patient._Gender = pa.ReadLine();

            pa.Close();

            string date = DateTime.Now.ToString();

            string appointment = "\n\n####-------Patient Info-------#### \n\n Date: " + date + "\n\nName: " + patient._FirstName + " " + patient._LastName +
                "\nAge: " + patient._Age + "\nGender: " + patient._Gender + "\n\nAppointment is fixed, Kindly visit Dr.Assistant for writing the prescription";

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
                return;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            notifyDoctor(doc);
            backgroundWorker1.ReportProgress(25);
            backgroundWorker1.ReportProgress(50);
            notifyPatient(doc);
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
            label1.Text = "Notifications Send";
            btnOK.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = " ";
            btnOK.Enabled = false;
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
