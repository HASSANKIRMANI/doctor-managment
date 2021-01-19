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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Console.Beep();
            this.Hide();
            First_Page f = new First_Page();
            f.ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpass.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        void checkCredentials(string username, string password)
        {
            if (txtusername.Text=="hk")//username == txtusername.Text)
            {
                if (txtpassword.Text=="123")//password == txtpassword.Text)
                {
                    if (First_Page.opt1 == 1)
                    {
                        this.Hide();
                        patientFunctions pf = new patientFunctions(username,true);
                        pf.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        this.Hide();
                        doctorFunctions df = new doctorFunctions(username,true);
                        df.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("LOGIN FAILED!! Enter Password Again" ,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Beep();

            string str = " ";
            string username = " ";
            string password = " ";

            if (First_Page.opt1 == 0)
            {
                string doc_path = First_Page.doc_path;
                try
                {
                    StreamReader sr = new StreamReader( doc_path + txtusername.Text + ".txt");
                    for (int i = 0; i < 2; ++i)
                        str = sr.ReadLine();

                    username = sr.ReadLine();
                    password = sr.ReadLine();
                    sr.Close();
                }
                catch
                {
                    MessageBox.Show("User Not Found" , "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                checkCredentials(username, password);
            }

            else if (First_Page.opt1 == 1)
            {
                string patient_path = First_Page.pat_path;
                try
                {
                    StreamReader sr = new StreamReader( patient_path + txtusername.Text + ".txt");
                    for (int i = 0; i < 2; ++i)
                        str = sr.ReadLine();

                    username = sr.ReadLine();
                    password = sr.ReadLine();
                    sr.Close();
                }
                catch
                {
                    MessageBox.Show("User Not Found" , "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                checkCredentials(username, password);
            }

            else
            {
                AdminClass admin = AdminClass.create_Instance(); //Single instance of admin class

                if (txtusername.Text == admin._username)
                {
                    if (txtpassword.Text == admin._password)
                    {
                        this.Hide();
                        Admin ad = new Admin(true);
                        ad.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password Unmatched" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Username Unmatched" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        } // button bracket
    }

}
