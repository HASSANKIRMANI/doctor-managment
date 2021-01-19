using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP_PROJECT_WINDOW_FORM
{
    public partial class viewInfo : Form
    {
        private string username;

        public viewInfo()
        {
            InitializeComponent();
        }
        public viewInfo(string username)
        {
            this.username = username;
            InitializeComponent();
        }
        private void viewInfo_Load(object sender, EventArgs e)
        {
            if (First_Page.opt1 == 1)//Static variable value
            {//1 for patient AND 0 for doctor
                lblDescription.Visible = false;
                txtDescription.Visible = false;
                lblSpeciality.Visible = false;
                lblFees.Visible = false;
                lblS.Visible = false;
                lblF.Visible = false;

                PatientInfo();
            }
            else
            {
                DoctorInfo();
            }
        }
        private void DoctorInfo()
        {
            pictureBox2.Visible = false;

            string doc_path = First_Page.doc_path;
            StreamReader sr = null;

            try
            {
                if (File.Exists(doc_path + username + ".txt"))
                    sr = new StreamReader(doc_path + username + ".txt");
                else
                    throw new CustomException("cannot open doctor usernames.txt");
                lblFname.Text = sr.ReadLine();
                lblLname.Text = sr.ReadLine();
                lblUsername.Text = sr.ReadLine();
                lblPass.Text = sr.ReadLine();
                lblAge.Text = sr.ReadLine();
                lblGender.Text = sr.ReadLine();
                lblSpeciality.Text = sr.ReadLine();
                lblPhone.Text = sr.ReadLine();
                lblAddress.Text = sr.ReadLine();
                lblPostal.Text = sr.ReadLine();
                lblFees.Text = sr.ReadLine();
                txtDescription.Text = sr.ReadLine();
                lblEmail.Text = sr.ReadLine();
                sr.Close();
            }
            catch
            {
                CustomException msg = new CustomException("Unable to Doctor File");
                MessageBox.Show(msg.Message, "Error");
            }
        }

        private void PatientInfo()
        {
            pictureBox1.Visible = false;
            string patient_path = First_Page.pat_path;
            try
            {
                StreamReader sr = new StreamReader(patient_path + username + ".txt");

                lblFname.Text = sr.ReadLine();
                lblLname.Text = sr.ReadLine();
                lblUsername.Text = sr.ReadLine();
                lblPass.Text = sr.ReadLine();
                lblAge.Text = sr.ReadLine();
                lblGender.Text = sr.ReadLine();
                lblPhone.Text = sr.ReadLine();
                lblAddress.Text = sr.ReadLine();
                lblPostal.Text = sr.ReadLine();
                lblEmail.Text = sr.ReadLine();
                sr.Close();
            }
            catch
            {
                CustomException msg = new CustomException("Unable to Doctor File");
                MessageBox.Show(msg.Message, "Error");
            }

        }
        //Exit
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure, You Want to Exit", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //Back button
        private void button1_Click(object sender, EventArgs e)
        {
            if(First_Page.opt1==0)
            {
                this.Hide();
                doctorFunctions df = new doctorFunctions(this.username);
                df.ShowDialog();
                this.Close();
            }
            if (First_Page.opt1 == 1)
            {
                this.Hide();
                patientFunctions pf = new patientFunctions(this.username);
                pf.ShowDialog();
                this.Close();
            }
        }
        //Edit info page
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            editInfo edit = new editInfo(this.username);
            edit.ShowDialog();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }
    }
}