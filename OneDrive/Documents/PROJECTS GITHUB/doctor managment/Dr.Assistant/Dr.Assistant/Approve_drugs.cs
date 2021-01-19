using System;
using System.Collections;
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
    public partial class Approve_drugs : Form
    {
        Drugs drug = new Drugs();

        bool adminView = true;

        string drugs_path;

        public Approve_drugs()
        {
            drugs_path = First_Page.drug_path;
            InitializeComponent();
        }


        public Approve_drugs(bool adminView)
        {
            drugs_path = First_Page.drug_path; 
            this.adminView = false; 
            InitializeComponent();
        }

        private void Approve_drugs_Load(object sender, EventArgs e)
        {
            if(!adminView)
            {
                lblApprove.Visible = false;
                btnapprove.Visible = false;
                btnBack.Visible = false;
                btndiscard.Visible = false;
                txtSno.Visible = false;
                lblSno.Visible = false;
                panel1.Visible = false;
            }
            else
            {
                btnDoc.Visible = false;
                lblSuggest.Visible = false;
            }
            textBox1.Enabled = false;
            textBox1.Text = DateTime.Now.ToString();
            constructDataGridView();
        }

        private void constructDataGridView()
        {
            //STYLING OF DATAGRIDVIEW
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Coral;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dataGridView1.ReadOnly = true;
            //Adding columns
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[0].Name = "S_No";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[1].Name = "Drug Type";
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[2].Name = "Drug Name";
            dataGridView1.Columns[3].Width = 248;
            dataGridView1.Columns[3].Name = "Drug Strenght";

            filereading();
        }

        private void filereading()
        {
            Stream read = null;
            int i = 1;
            IFormatter formatter = new BinaryFormatter();
            string path = drugs_path + "Drug_Suggestions.txt";


            try 
            {
                if (File.Exists(path))
                {
                    read = new FileStream(path, FileMode.Open, FileAccess.Read);
                }
                else
                    throw new CustomException("Cannot open Drugs.txt");
            }
            catch(CustomException e)
            {
                MessageBox.Show(e.Message);
            }

            while (read.Position != read.Length)
            {
                drug = (Drugs)formatter.Deserialize(read);
                AddRow(i);
                i += 1;
            }
            read.Close();
        }

        //Every time when drug is to be added
        void AddRow(int i)
        {
            ArrayList row = new ArrayList();
            row.Add(i);
            row.Add(drug._drugType);
            row.Add(drug._drugName);
            row.Add(drug._drugStrenght);
            dataGridView1.Rows.Add(row.ToArray());
        }
        //When admin wants to remove any row
        void RemoveSuggestion(int count)
        {
            Stream read = null;
            IFormatter formatter = new BinaryFormatter();
            string path = drugs_path;

            try
            {
                if (File.Exists(path + "Drug_Suggestions.txt"))
                    read = new FileStream(path + "Drug_Suggestions.txt", FileMode.Open, FileAccess.Read);
                else
                    throw new CustomException("Cannot open Drugs.Suggestion.txt");
            }
            catch(CustomException e)
            {
                MessageBox.Show(e.Message);
            }
            Stream write = new FileStream(path + "temp.txt", FileMode.Create, FileAccess.Write);

            int i =0 ;
            while (read.Position != read.Length)
            {
                i += 1;
                drug = (Drugs)formatter.Deserialize(read);
                if( i!=count ) 
                {
                    formatter.Serialize(write, drug);
                }
            }
            read.Close();
            write.Close();

            File.Delete(path + "Drug_Suggestions.txt");
            File.Move(path + "temp.txt", path + "Drug_Suggestions.txt");

            dataGridView1.Rows.Clear();

            filereading();
        }
        //When admin wants to approve any row
        void Approve_drug(int count)
        {
            Stream read = null;
            IFormatter formatter = new BinaryFormatter();
            string path = drugs_path +"Drug_Suggestions.txt";

            try
            {
                if (File.Exists(path))
                {
                    read = new FileStream(path, FileMode.Open, FileAccess.Read);
                }
                else
                    throw new CustomException("Cannot open DrugSuggestions.txt");
            }
            catch(CustomException e)
            {
                MessageBox.Show(e.Message);
            }

            for (int i = 1; i<=count;++i)
            {
                drug = (Drugs)formatter.Deserialize(read);
            }
            read.Close();

            MessageBox.Show(drug._drugType);
            MessageBox.Show(drug._drugName);
            MessageBox.Show(drug._drugStrenght);


            path = drugs_path + "Drugs.txt";
            Stream write = new FileStream(path, FileMode.Append, FileAccess.Write);
            formatter.Serialize(write, drug);
            write.Close();
            RemoveSuggestion(count);

        }

        bool isValidSno()
        {
            int flag = 0;

            if (string.IsNullOrEmpty(txtSno.Text))
            {
                errorProvider1.SetError(txtSno, "S.no Must Be Entered");
                txtSno.Focus();
                flag = 1;
            }
            else if (Int32.Parse(txtSno.Text) >= dataGridView1.RowCount)
            {
                errorProvider1.SetError(txtSno, "S.no Must Be Less Than No of Rows");
                txtSno.Focus();
                flag = 1;
            }
            else if (Int32.Parse(txtSno.Text) <= 0)
            {
                errorProvider1.SetError(txtSno, "S.no Must Be Greater Than Zero");
                txtSno.Focus();
                flag = 1;
            }

            if (flag == 0)
                return true;
            else
                return false;
        }

        private void btnapprove_Click(object sender, EventArgs e)
        {
            if (isValidSno())
            {
                errorProvider1.Clear();
                int count = Int32.Parse(txtSno.Text);
                Approve_drug(count);
            }
        }

        private void btndiscard_Click(object sender, EventArgs e)
        {
            if (isValidSno())
            {
                errorProvider1.Clear();
                int count = Int32.Parse(txtSno.Text);
                RemoveSuggestion(count);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Tablets at = new Add_Tablets();
            at.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Tablets vt = new View_Tablets();
            vt.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
