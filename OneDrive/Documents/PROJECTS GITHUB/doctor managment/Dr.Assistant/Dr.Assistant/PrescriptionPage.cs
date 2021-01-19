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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOP_PROJECT_WINDOW_FORM
{
    public partial class PrescriptionPage : Form
    {

        List<string> symptoms = new List<string>();
        string diagnose = null;
        string doc_username;
        string patient_username;

        Prescription prescribe = new Prescription();

        List<string> prescription = new List<string>();

        public PrescriptionPage()
        {
            InitializeComponent();
        }

        public PrescriptionPage(string doc_username, string patient_username)
        {
            this.doc_username = doc_username;
            this.patient_username = patient_username;

            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }


        //LOAD
        private void Prescription_Load(object sender, EventArgs e)//for Symptoms Listbox
        {

            AddDrugs();
            btnAdd.Enabled = false;
            btnAdd.BackColor = Color.Silver;

            Symptoms_Diagnosis();

            txtDiagnose.Items.Add(this.diagnose);

            foreach (string s in symptoms)
                lbSymptoms.Items.Add(s);
        }

        int readEmptyLines() //reading empty lines in patient file
        {
            string line;
            int count = 0;
            StreamReader sr = null;
            //          MessageBox.Show("In Read");
            try
            {
                if (File.Exists(First_Page.pat_path + patient_username + ".txt"))
                    sr = new StreamReader(First_Page.pat_path + patient_username + ".txt");
                else
                    throw new CustomException("Unable to Doctor File");
            }
            catch(CustomException e)
            {
                MessageBox.Show(e.Message , "Error");
            }

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

        void Symptoms_Diagnosis() //Reading symptoms and diagnose disease from patient file
        {
            int cnt = 0;
            int EmptyLines = 0;

            EmptyLines = readEmptyLines();

            string trash;

            StreamReader sr = null;
            try
            {
                if (File.Exists(First_Page.pat_path + patient_username + ".txt"))
                    sr = new StreamReader(First_Page.pat_path + patient_username + ".txt");
                else
                    throw new CustomException("Unable to open Doctor File");
            }
            catch(CustomException e)
            {
                MessageBox.Show(e.Message, "Error");
            }

            while (true)
            {
                trash = sr.ReadLine();
                if (string.IsNullOrEmpty(trash))
                {
                    cnt += 1;
                    if (cnt == EmptyLines - 1)
                    {
                        break;
                    }
                }
            }
            trash = sr.ReadLine();

            while (true)
            {
                if ((trash = sr.ReadLine()) == "Symptoms End")
                {
                    break;
                }
                this.symptoms.Add(trash);
            }

            this.diagnose = sr.ReadLine();
            sr.Close();
        }

        void AddDrugs() //for adding drugs_names in the combo box
        {
            Drugs drug = null;

            IFormatter formatter = new BinaryFormatter();

            string path = First_Page.drug_path + "\\" + "Drugs.txt";

            Stream read = new FileStream(path, FileMode.Open, FileAccess.Read);

            while (read.Position != read.Length)
            {
                drug = (Drugs)formatter.Deserialize(read);
                comboDrug.Items.Add(drug._drugName);
            }
            read.Close();
        }

        //Writing prescription in file
        void writePrescription()
        {
            IFormatter formatter = new BinaryFormatter();

            string path = First_Page.pres_path + patient_username + "_prescription.txt";

            Stream write = null;
            try
            {
                if (File.Exists(path))
                {
                    write = new FileStream(path, FileMode.Append, FileAccess.Write);
                }
                else
                {
                    write = new FileStream(path, FileMode.Create, FileAccess.Write);
                }
            }
            catch { MessageBox.Show("Unable to Open Prescription File"); }

            formatter.Serialize(write, prescribe);
            write.Close();

        }//function bracket


        void AddDrug()
        {
            prescribe._drugType = txtType.Text;
            prescribe._drugName = comboDrug.Text;
            prescribe._drugStrenght = txtStrength.Text;
            prescribe._drugDose = txtDose.Text;
            prescribe._drugDuration = txtDuration.Text;
            prescribe._drugAdvice = txtAdvice.Text;


            List<string> save = new List<string>();
            save.Add(txtType.Text);
            save.Add(comboDrug.Text);
            save.Add(txtStrength.Text);
            save.Add(txtDose.Text);
            save.Add(txtDuration.Text);
            save.Add(txtAdvice.Text);
            save.Add(" ");
            

            if (MessageBox.Show("Do You Want This Drug In Prescription??", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (string drug in save)
                {
                    prescription.Add(drug);
                }

                writePrescription();

                btnSave.Enabled = false;
                btnSave.BackColor = Color.Silver;
                btnAdd.Enabled = true;
                btnAdd.BackColor = Color.Black;

                MessageBox.Show("Drug Saved");
            }
        }

        bool validateTextBoxes() //validating text boxes (they should not be empty at time of drug submission)
        {
            int flag = 0;

            if(string.IsNullOrEmpty(txtType.Text)) { errorProvider1.SetError(txtType, "Please Specify Drug Type"); flag = 1; }
            else { errorProvider1.Clear(); }
            if (string.IsNullOrEmpty(comboDrug.Text)) { errorProvider2.SetError(comboDrug, "Please Specify Drug Name"); flag = 1; }
            else { errorProvider2.Clear(); }
            if (string.IsNullOrEmpty(txtStrength.Text)) { errorProvider3.SetError(txtStrength, "Please Specify Drug Strength"); flag = 1; }
            else { errorProvider3.Clear(); }
            if (string.IsNullOrEmpty(txtDose.Text)) { errorProvider4.SetError(txtDose, "Please Specify Drug Dose"); flag = 1; }
            else { errorProvider4.Clear(); }
            if (string.IsNullOrEmpty(txtDuration.Text)) { errorProvider5.SetError(txtDuration, "Please Specify Drug Duration"); flag = 1; }
            else { errorProvider5.Clear(); }
            if (string.IsNullOrEmpty(txtAdvice.Text)) { errorProvider6.SetError(txtAdvice, "Please Specify Advice about taking Drug"); flag = 1; }
            else { errorProvider6.Clear(); }

            if (flag == 0)
                return true;
            else
                return false;
        }

        //SAVE
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateTextBoxes())
            {
                AddDrug();
            }
        }// save button bracket

        //ADD button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtType.Clear();
            txtType.Focus();
            comboDrug.Text = "";
            txtDuration.Clear();
            txtDose.Clear();
            txtStrength.Clear();
            txtAdvice.Clear();

            btnAdd.Enabled = false;
            btnAdd.BackColor = Color.Silver;
            btnSave.Enabled = true;
            btnSave.BackColor = Color.Black;
        }// add button bracket

        //View button
        private void btnView_Click(object sender, EventArgs e)
        {
            lbDrugs.Items.Clear();
            lbDrugs.Items.Add("Prescription");
            lbDrugs.Items.Add("");

            foreach (string item in prescription)
            {
                lbDrugs.Items.Add(item);
            }
        }//view Button

        //Done button
        private void button1_Click(object sender, EventArgs e) //back to Doctor's Appointment page
        {
            this.Hide();
            this.Close();
        }

        private void lbSymptoms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDrug_TextChanged(object sender, EventArgs e)
        {

        }

        private void vIEWTABLETSToolStripMenuItem_Click(object sender, EventArgs e) //opening view tablets page in Doctor view mode
        {
            View_Tablets view = new View_Tablets(false); //true-> admin view
            view.ShowDialog();                           //false-> doctor view
        }
    }
}
