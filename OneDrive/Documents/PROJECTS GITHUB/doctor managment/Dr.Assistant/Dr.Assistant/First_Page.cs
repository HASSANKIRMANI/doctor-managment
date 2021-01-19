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
    //Class
    public partial class First_Page : Form
    {
        //making static variable so that it can be used in other form by just writing First_Page.opt1
        public static int opt1; //variable created to store which option created (opt1-> doctor/patient)
        public static int opt2; //variable created to store which option created (opt2->  login /sign)

        public static string doc_path;
        public static string pat_path;
        public static string drug_path;
        public static string pres_path;


        public First_Page()
        {
            InitializeComponent();
        }
        private void txtcombo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtcombo1.SelectedIndex == 2)
            {
                txtcombo2.SelectedIndex = 0;
                txtcombo2.Enabled = false;
            }
            else
            {
                txtcombo2.Text = null;
                txtcombo2.Enabled = true;
            }
        }
        //Proceed button
        private void txtproceed_Click(object sender, EventArgs e)
        {
            Console.Beep();
            opt1 = txtcombo1.SelectedIndex; //getting the index of the option selected (doctor index ==0,patient index==1)
            opt2 = txtcombo2.SelectedIndex;  //getting the index of the option selected (login index==0 ,signup index==1)

            if (txtcombo2.SelectedIndex == 0 && (txtcombo1.SelectedIndex == 0 || txtcombo1.SelectedIndex == 1 || txtcombo1.SelectedIndex == 2))
            {
                this.Hide();
                Login l = new Login();
                l.ShowDialog();
                this.Close();
            }
            else if (txtcombo2.SelectedIndex == 1 && (txtcombo1.SelectedIndex == 0 || txtcombo1.SelectedIndex == 1))
            {
                this.Hide();
                SignUp sign = new SignUp();
                sign.ShowDialog();
                this.Close();
            }
        }
        //Exit button
        private void txtexit_Click(object sender, EventArgs e)
        {
            Console.Beep();
            this.Close();
        }

        private void First_Page_Load(object sender, EventArgs e)
        {
            string applicationLocation = System.Reflection.Assembly.GetEntryAssembly().Location;
            string applicationDirectory = System.IO.Path.GetDirectoryName(applicationLocation);
            if (Directory.Exists(applicationDirectory + "\\Doctor"))
            {
                doc_path = applicationDirectory + "\\" + "Doctor\\";
                pat_path = applicationDirectory + "\\" + "Patient\\";
                drug_path = applicationDirectory + "\\" + "Drugs\\";
                pres_path = applicationDirectory + "\\" + "Prescription\\";
            }

            else
            {
                try
                {
                    //function
                    createFolder_files(applicationDirectory);
                }
                catch
                {
                    MessageBox.Show("Choose another path !");
                }
            }
        }

        void createFolder_files(string folder_path)
        {
            StreamWriter sw = null;

            try
            {
                //doctor
                doc_path = folder_path + "\\Doctor";
                Directory.CreateDirectory(doc_path);

                doc_path = folder_path + "\\" + "Doctor\\";
                sw = new StreamWriter(doc_path + "usernames.txt");
                sw.Close();

                //patient
                pat_path = folder_path + "\\" + "Patient";
                Directory.CreateDirectory(pat_path);

                pat_path = folder_path + "\\" + "Patient\\";
                sw = new StreamWriter(pat_path + "usernames.txt");
                sw.Close();

                //drugs
                drug_path = folder_path + "\\" + "Drugs";
                Directory.CreateDirectory(drug_path);

                drug_path = folder_path + "\\" + "Drugs\\";
                sw = new StreamWriter(drug_path + "Drugs.txt");
                sw.Close();

                // Drugs suggestion
                sw = new StreamWriter(drug_path + "Drug_Suggestions.txt");
                sw.Close();

                //prescription
                pres_path = folder_path + "\\" + "Prescription";
                Directory.CreateDirectory(pres_path);
                pres_path = folder_path + "\\" + "Prescription\\";

            }
            catch
            {
                CustomException msg = new CustomException("Unable to Open a file or Create Directory");
                MessageBox.Show(msg.Message);
            }
        }

    }
}
