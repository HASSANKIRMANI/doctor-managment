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
    public partial class Diagnosis : Form
    {
        string username;
        string date_time;
        List<string> diseases = new List<string>();
        Diseasess d;

        string patient_path;
        string doctor_path;

        public Diagnosis()
        {
            InitializeComponent();
        }

        public Diagnosis(string username)
        {
            patient_path = First_Page.pat_path;
            doctor_path = First_Page.doc_path;
            this.username = username;
            InitializeComponent();
        }
        private void Diagnosis_Load(object sender, EventArgs e)
        {
            btnFix.Visible = false;
            lblDiagnosis.Visible = false;
            lblSuggested.Visible = false;
            txtDiagnose.Visible = false;
            txtDoctor.Visible = false;
            dateTimePicker1.Value = DateTime.Now;
        }
        bool isAppointmentPresent() //to check wheather the user already have a appointment or not
        {                           //for that checking username in the doctor file 

            string doc_path = First_Page.doc_path;

            StreamReader user = null;
            StreamReader sr = null;

            try
            {
                if (File.Exists(doc_path + "usernames.txt"))
                    user = new StreamReader(doc_path + "usernames.txt");
                else
                    throw new CustomException("Unable to Open Usernames.txt");
            }
            catch (CustomException e)
            { MessageBox.Show(e.Message); }

            string users;
            string line;

            while ((users = user.ReadLine()) != null)//reading usernames of doc from username files
            {
                try
                {
                    sr = new StreamReader(doc_path + users + ".txt");
                }
                catch
                {
                    MessageBox.Show("Unable to Open patient.txt");
                    return false;
                }

                while (true)
                {
                    line = sr.ReadLine();
                    if (string.IsNullOrEmpty(line))  //breaking at first empty line after general info
                    {
                        break;
                    }
                }

                while ((line = sr.ReadLine()) != null) //checking appointment names in doc file
                {
                    if (this.username == line)
                    {
                        sr.Close();
                        user.Close();
                        return true;
                    }
                }//inner while

                sr.Close();

            }//outer while

            user.Close();
            return false;

        }
        //Submit button
        private void button1_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you sure you want to submit these symptoms?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                diseases.Clear();

                txtDiagnose.Clear();
                txtDoctor.Clear();

                foreach (string s in checkedListBox1.CheckedItems)
                {
                    diseases.Add(s);    //diseases is a list of strings
                }


                lbSymptoms.Items.Clear(); //That symptoms enetered by user displayed in listbox

                foreach (string s in diseases)
                    lbSymptoms.Items.Add(s);

                d = new Diseasess(diseases);

                if (d._disease_predicted == null)
                {
                    MessageBox.Show("Please Select the Symptoms");
                }

                else
                {
                    //Calling function to check if appointment there in this class
                    if(!isAppointmentPresent())
                    btnFix.Visible = true;
                    txtDiagnose.Visible = true;
                    txtDoctor.Visible = true;
                    lblDiagnosis.Visible = true;
                    lblSuggested.Visible = true;
                    txtDoctor.Text = d._doctor_suggest;
                    txtDiagnose.Text = d._disease_predicted;
                    txtDoctor.Enabled = false;
                    txtDiagnose.Enabled = false;
                }
            }

        }
        //Back button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientFunctions pf = new patientFunctions(this.username);
            pf.ShowDialog();
            this.Close();
        }
        //View button
        private void view_Click(object sender, EventArgs e)
        {
            lbSymptoms.Items.Clear();

            foreach (string item in checkedListBox1.CheckedItems)
                lbSymptoms.Items.Add(item);
        }
        //fix Appointment Button
        private void button3_Click(object sender, EventArgs e) 
        {
            if (MessageBox.Show("Are You Sure, You Want Fix Appointment", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (MessageBox.Show("Prescription and Report of previous Appointment will be removed, Do You Want to Continue?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    writeSymptoms_updatePatientFile();

                    string path = First_Page.pres_path + username + "_prescription.txt";
                    if (File.Exists(path))
                    {
                        File.Delete(path); //if a precription file of patient exits previously than delete it and a new file will be created for next appointement
                    }

                    this.Hide();
                    PatientAppointment pa = new PatientAppointment(username,false);
                    pa.ShowDialog();                
                    this.Close();

                }
            }
        }
        void writeSymptoms_updatePatientFile()
        {
            if (string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                date_time = DateTime.Now.ToString();
            }
            else
            {
                string date = null;
                if (date == DateTime.Now.ToString())
                    date_time = date;
                else
                    date_time = DateTime.Now.ToString();
            }

            StreamWriter sw = File.AppendText(patient_path + username + ".txt");

            sw.WriteLine();
            sw.WriteLine(date_time);

            foreach (string s in diseases)
                sw.WriteLine(s);

            sw.WriteLine("Symptoms End");

            sw.WriteLine(d._disease_predicted);
            sw.WriteLine(d._doctor_suggest);
            sw.Close();
        }

        //Exit button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure, You Want to Exit", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
