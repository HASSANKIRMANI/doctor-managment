using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOP_PROJECT_WINDOW_FORM
{
    public partial class Add_Tablets : Form
    {
        Drugs drug = new Drugs();


        public Add_Tablets()
        {
            InitializeComponent();
        }

        private void Add_Tablets_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Text = DateTime.Now.ToString();
            btnAdd.Enabled = false;
            btnAdd.BackColor = Color.Silver;
            btnSubmit.Enabled = true;
            btnSubmit.BackColor = Color.Black;
        }
    
        bool validateTextBoxes()
        {
            int flag = 0;

            if (string.IsNullOrEmpty(DrugTypeTb.Text)) { errorProvider1.SetError(DrugTypeTb, "Please Specify Drug Type"); flag = 1; }
            else { errorProvider1.Clear(); }
            if (string.IsNullOrEmpty(DrugNameTb.Text)) { errorProvider2.SetError(DrugNameTb, "Please Specify Drug Name"); flag = 1; }
            else { errorProvider2.Clear(); }
            if (string.IsNullOrEmpty(DrugStrenghtTb.Text)) { errorProvider3.SetError(DrugStrenghtTb, "Please Specify Drug Strength"); flag = 1; }
            else { errorProvider3.Clear(); }

            if (flag == 0)
                return true;
            else
                return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validateTextBoxes())
            {
                if (MessageBox.Show("Are You Sure, You Want to Add this Tablet", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Serializing();
                    btnSubmit.Enabled = false;
                    btnSubmit.BackColor = Color.Silver;
                    btnAdd.Enabled = true;
                    btnAdd.BackColor = Color.Black;
                }
            }
        }

        void Serializing()
        {

            drug._drugType = DrugTypeTb.Text;
            drug._drugName = DrugNameTb.Text;
            drug._drugStrenght = DrugStrenghtTb.Text;
            Stream stream = null;
            IFormatter formatter = new BinaryFormatter();
            string path = First_Page.drug_path + "Drugs.txt";

            try
            {
                stream = new FileStream( path , FileMode.Append, FileAccess.Write);
            }
            catch
            {
                MessageBox.Show("Cannot open DRUGS.txt");
            }
            formatter.Serialize(stream, drug);
            stream.Close();
        }

        //Back
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.ShowDialog();
            this.Close();
        }
        //add
        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Doctors_Info di = new Doctors_Info();
            di.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search_doctor search = new Search_doctor();
            search.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Tablets vt = new View_Tablets();
            vt.ShowDialog();
            this.Close();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            this.Hide();
            Approve_drugs approve = new Approve_drugs();
            approve.ShowDialog();
            this.Close();
        }

        private void DrugTypeTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch;
            ch = e.KeyChar;
            if (ch == 13)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void DrugNameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch;
            ch = e.KeyChar;
            if (ch == 13)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void DrugStrenghtTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch;
            ch = e.KeyChar;
            if (ch == 13)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        private void DrugTypeTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void DrugNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void DrugStrenghtTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
