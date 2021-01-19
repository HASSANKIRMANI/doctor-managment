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
    public partial class SuggestDrugs : Form
    { 
        string username;

        public SuggestDrugs()
        {
            InitializeComponent();
        }

        public SuggestDrugs(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void SuggestDrugs_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnAdd.BackColor = Color.Silver;
        }

        void Serializing() //writing suggest drug object in the file
        {
            Drugs drug = new Drugs();
            drug._drugType = DrugTypeTb.Text;
            drug._drugName = DrugNameTb.Text;
            drug._drugStrenght = DrugStrenghtTb.Text;

            Stream stream = null;
            IFormatter formatter = new BinaryFormatter();

            string path = First_Page.drug_path + "\\" + "Drug_Suggestions.txt";

            try
            {
                if (File.Exists(path))
                    stream = new FileStream(path, FileMode.Append, FileAccess.Write);
                else
                    throw new CustomException("Cannot open file");
            }
            catch(CustomException e)
            {
                MessageBox.Show(e.Message, "Error");
            }

            formatter.Serialize(stream, drug);
            stream.Close();
        }

        bool validateTextBoxes() //validating that textboxes should not be empty
        {
            int flag = 0;

            if (string.IsNullOrEmpty(DrugTypeTb.Text)) { errorProvider1.SetError(DrugTypeTb, "Please Specify Drug Type"); flag = 1; }
            if (string.IsNullOrEmpty(DrugNameTb.Text)) { errorProvider1.SetError(DrugNameTb, "Please Specify Drug Name"); flag = 1; }
            if (string.IsNullOrEmpty(DrugStrenghtTb.Text)) { errorProvider1.SetError(DrugStrenghtTb, "Please Specify Drug Strength"); flag = 1; }

            if (flag == 0)
                return true;
            else
                return false;
        }

        //Submit button

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validateTextBoxes())
            {
                errorProvider1.Clear();
                if (MessageBox.Show("Are You Sure, You Want to Suggest this Drug", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Serializing();

                    btnSubmit.Enabled = false;
                    btnSubmit.BackColor = Color.Silver;

                    btnAdd.Enabled = true;
                    btnAdd.BackColor = Color.Black;
                }
            }
        }

        //Add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DrugTypeTb.Clear();
            DrugNameTb.Clear();
            DrugStrenghtTb.Clear();
            DrugTypeTb.Focus();

            btnAdd.Enabled = false;
            btnAdd.BackColor = Color.Silver;

            btnSubmit.Enabled = true;
            btnSubmit.BackColor = Color.Black;
        }

        //back
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            doctorFunctions functions = new doctorFunctions(this.username);
            functions.ShowDialog();
            this.Close();
        }

        //view suugested tablet list
        private void button2_Click(object sender, EventArgs e)
        {
            Approve_drugs approve = new Approve_drugs(false);
            approve.ShowDialog();
        }

        // view tablet list
        private void button1_Click(object sender, EventArgs e)
        {
            View_Tablets view = new View_Tablets(false);
            view.ShowDialog();
        }

    }
}
