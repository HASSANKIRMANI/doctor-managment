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
    public partial class BookAppointment : Form
    {
        string username;
        string date_time;

        string doc_path;
        string patient_path;

        List<string> symptoms = new List<string>();

        public BookAppointment()
        {
            InitializeComponent();
        }

        public BookAppointment(string username)
        {
            this.username = username;

            doc_path = First_Page.doc_path;

            patient_path = First_Page.pat_path;

            InitializeComponent();
        }
        private void BookAppointment_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            dateTimePicker1.Value = DateTime.Now;
        }

        int readEmptyLines() //reading empty lines in Patient File
        {
            string line;
            int count = 0;
            StreamReader sr = null;

            try
            {
                if (File.Exists(patient_path + username + ".txt"))
                    sr = new StreamReader(patient_path + username + ".txt");
                else
                    throw new CustomException("Unable to Open Patient.txt");
            }
            catch(CustomException e)
            { MessageBox.Show(e.Message); }

            while (true)
            {
                line = sr.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    count += 1;
                }
                if (line == null)
                {
                    break;
                }
            }

            sr.Close();

            return count;
        } //readline bracket

        int readEmptyLines(string user) //Function Overloading  //reading empty lines in Doctor File
        {
            string line;
            int count = 0;
            StreamReader sr = null;

            try
            {
                if(File.Exists(doc_path + user + ".txt"))
                sr = new StreamReader(doc_path + user + ".txt");
                else
                    throw new CustomException("Unable to Open Doctor.txt");
            }
            catch(CustomException e )
            { MessageBox.Show(e.Message); }

            while (true)
            {
                line = sr.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    count += 1;
                }
                if (line == null)
                {
                    break;
                }
            }

            sr.Close();

            return count;

        }//function bracket

        void updatePatientFile()  //writing date , symptoms , disease and specialist in the patient file
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
                    date_time = DateTime.Now.Date.ToString();
            }

            foreach (string sym in lb1.Items)
            {
                symptoms.Add(sym);
            }

            StreamWriter sw = File.AppendText(patient_path + username + ".txt");

            sw.WriteLine();
            sw.WriteLine(date_time);

            foreach(string sym in symptoms)
            {
                sw.WriteLine(sym);
            }
            sw.WriteLine("Symptoms End");

            sw.WriteLine("-");

            string speciality = comboSpeciality.Text;
            sw.WriteLine(speciality);

            sw.Close();

        }

        bool validateTextBoxes()
        {
            int flag = 0;

            if(lb1.Items.Count == 0) { errorProvider1.SetError(txtSymptoms, "Please Specify Symptoms"); flag = 1; }
            else { errorProvider1.Clear(); }

            if (string.IsNullOrEmpty(comboSpeciality.Text)) { errorProvider2.SetError(comboSpeciality, "Please Specify Specialist"); flag = 1; }
            else { errorProvider2.Clear(); }

            if (flag == 0)
                return true;
            else
                return false;
        }
        //Fix appointment
        private void button1_Click(object sender, EventArgs e)
        {
            if (validateTextBoxes())
            {
                if (MessageBox.Show("Are You Sure, You Want to Fix Appointment", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Prescription and Report of previous Appointment will be removed, Do You Want to Continue?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        updatePatientFile(); //wrinting info in patient file

                        string path = First_Page.pres_path + username + "_prescription.txt";
                        if (File.Exists(path))
                        {
                            File.Delete(path); //if a precription file of patient exits previously than delete it and a new file will be created for next appointement
                        }

                        this.Hide();
                        PatientAppointment pa = new PatientAppointment(username,false);
                        //pa.fixAppointment();  //we want to fix the appointment and find doc
                        pa.ShowDialog();
                        this.Close();
                    }
                }

            }
        }
        //Add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSymptoms.Text))
            {
                lb1.Items.Add(txtSymptoms.Text);
                txtSymptoms.Clear();
            }
            else
                errorProvider1.SetError(txtSymptoms, "Please Enter some symptoms !");

        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnUpdate.BackColor = Color.Black;
            btnAdd.Enabled = false;
            btnAdd.BackColor = Color.Silver;
            try
            {
                txtSymptoms.Text = lb1.SelectedItem.ToString();
            }
            catch { }
        }
        //Update Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = lb1.SelectedIndex;
            lb1.Items.RemoveAt(index);
            lb1.Items.Insert(index, txtSymptoms.Text);
            txtSymptoms.Clear();
            btnUpdate.Enabled = false;
            btnUpdate.BackColor = Color.Silver;
            btnAdd.Enabled = true;
            btnAdd.BackColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientFunctions pf = new patientFunctions(this.username);
            pf.ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure, You Want to Exit", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void txtSymptoms_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
