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
using System.Net.Mail;
using System.Web;
using System.IO;

namespace OOP_PROJECT_WINDOW_FORM
{
    public partial class btnResend : Form
    {
        doctor doc =  null;
        Patient patient = new Patient();

        string randomNumber = null;

        public btnResend()
        {
            InitializeComponent();
        }

        public btnResend(doctor d)
        {
            this.doc = d;
            InitializeComponent();
        }

        public btnResend(Patient patient)
        {
            this.patient = patient;
            InitializeComponent();
        }

        private void EmailVerification_Load(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
            txtPin.Enabled = false;
        }

        void startTime()
        {

        }

        int count = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count -= 1;

            lblTimer.Text = "00 : " + count.ToString();

        if(count==30)
            {
                btnSend.Text = "Resend Pin";
                btnSend.Enabled = true;
                btnSend.BackColor = Color.Black;
            }
            if (count == 0)
            {
                lblPin.Text = "";
                lblTimer.Text = "";

                timer1.Stop();

                lblMsg.Visible = true;

                txtPin.Enabled = false;

                btnSend.Text = "Resend Pin";
                btnSend.Enabled = true;
                btnSend.BackColor = Color.Black;
            }

        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void txtSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (patient.isValidEmail(txtEmail.Text))
                {
                    try
                    {
                        count = 60;
                        lblError.Text = "";
                        Random rnd = new Random();
                        randomNumber = (rnd.Next(1000, 9999)).ToString();

                        EmailProgressing check = new EmailProgressing(txtEmail.Text, randomNumber);
                        check.ShowDialog();

                        timer1.Start();

                        txtPin.Enabled = true;

                        btnSend.Enabled = false;
                        btnSend.BackColor = Color.Silver;
                    }
                    catch
                    {
                        MessageBox.Show("Unable to Send Pin");
                    }
                }
                else
                {
                    throw new CustomException("Invalid Email");
                }
            }
            catch(CustomException msg)
            {
                lblError.Text = msg.Message;
            }
        }

        void patientSignUp()
        {
            string patient_path = First_Page.pat_path;

            patient._EmailAddress = txtEmail.Text;

            StreamWriter sw = new StreamWriter(patient_path + patient._Username + ".txt");
            StreamWriter user = File.AppendText(patient_path + "usernames.txt");

            sw.WriteLine(patient._FirstName);
            sw.WriteLine(patient._LastName);

            sw.WriteLine(patient._Username);
            user.WriteLine(patient._Username);

            sw.WriteLine(patient._Password);
            sw.WriteLine(patient._Age);
            sw.WriteLine(patient._Gender);
            sw.WriteLine(patient._PhoneNo);
            sw.WriteLine(patient._Address);
            sw.WriteLine(patient._PostalCode);
            sw.WriteLine(patient._EmailAddress);
            sw.Close();
            user.Close();
            MessageBox.Show("Sign Up Successfull!!");
        }


        void doctorSignUp()
        {
            string doc_path = First_Page.doc_path;
            //string doc_path = 

            doc._EmailAddress = txtEmail.Text;

            StreamWriter sw = new StreamWriter(doc_path + doc._Username + ".txt");
            StreamWriter user = File.AppendText(doc_path + "usernames.txt");

            sw.WriteLine(doc._FirstName);
            sw.WriteLine(doc._LastName);

            user.WriteLine(doc._Username); //saving username in a separate file so that usernames can be accessed later
            sw.WriteLine(doc._Username);

            sw.WriteLine(doc._Password);
            sw.WriteLine(doc._Age);
            sw.WriteLine(doc._Gender);
            sw.WriteLine(doc._Speciality);
            sw.WriteLine(doc._PhoneNo);
            sw.WriteLine(doc._Address);
            sw.WriteLine(doc._PostalCode);
            sw.WriteLine(doc._Fee);
            sw.WriteLine(doc._description);
            sw.WriteLine(doc._EmailAddress);

            sw.Close();
            user.Close();
            MessageBox.Show("Sign Up Successfull!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {
            string pin = txtPin.Text;

            if (pin == randomNumber)
            {
                timer1.Stop();
                lblPin.Text = "";

                if (First_Page.opt1 == 0) { doctorSignUp(); }
                else { patientSignUp(); }
                this.Hide();
                First_Page first = new First_Page();
                first.ShowDialog();
                this.Close();
            }
            else
            {
                lblPin.Text = "Wrong Pin Code";
            }
        }

    }
}
