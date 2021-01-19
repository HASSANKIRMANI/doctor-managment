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
using System.Diagnostics;

namespace OOP_PROJECT_WINDOW_FORM
{
    public partial class View_Tablets : Form
    {

        int option;
        Drugs d=null;
        bool adminView = true;  //default admin view
        string drugs_path;

        public View_Tablets()
        {
            option = -1;
            drugs_path = First_Page.drug_path;
            InitializeComponent();
        }
        public View_Tablets(bool adminView)
        {
            this.adminView = adminView; // true-> admin view
            InitializeComponent();      // false -> doctor view
        }

        private void View_Tablets_Load(object sender, EventArgs e)
        {

            btndelete.Visible = false;
            btnupdate.Visible = false;

            textBox1.Enabled = false;

            textBox1.Text = DateTime.Now.ToString();

            if (!adminView)//if this page is called from precription page
            {
                label2.Visible = false;
                panel2.Visible = false;
                btnBack.Visible = false;
                btndelete.Visible = false;
                btnupdate.Visible = false;
                txttb.Visible = false;
                button1.Visible = false;
            }
            else
            {
                btnPrescription.Visible = false;
            }
            constructDataGridView();
        }

        private void constructDataGridView()
        {
            //Adding columns
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Coral;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            //dataGridView1.ReadOnly = true;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[0].Name = "S_No";
            dataGridView1.Columns[1].Width = 220;
            dataGridView1.Columns[1].Name = "Drug Type";
            dataGridView1.Columns[2].Width = 220;
            dataGridView1.Columns[2].Name = "Drug Name";
            dataGridView1.Columns[3].Width = 208;
            dataGridView1.Columns[3].Name = "Drug Strenght";
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            filereading();
        }

        private void filereading()
        {
            int i=1;
            IFormatter formatter = new BinaryFormatter();
            Stream read = null;
            string path = First_Page.drug_path + "Drugs.txt";
            try
            {
                if (File.Exists(path))
                    read = new FileStream(path, FileMode.Open, FileAccess.Read);
                else
                    throw new CustomException("Cannot open file");
            }
            catch(CustomException e)
            {
                MessageBox.Show(e.Message);
            }
            while (read.Position != read.Length)
            {
                d = (Drugs)formatter.Deserialize(read);
                AddRow(i);
                i += 1;
            }
            read.Close();
        }

        void AddRow(int i)
        {
            ArrayList row = new ArrayList();
            row.Add(i);
            row.Add(d._drugType);
            row.Add(d._drugName);
            row.Add(d._drugStrenght);
            dataGridView1.Rows.Add(row.ToArray());
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.ShowDialog();
            this.Close();
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void btnApprove_Click(object sender, EventArgs e)
        {
            this.Hide();
            Approve_drugs approve = new Approve_drugs();
            approve.ShowDialog();
            this.Close();
        }

        void RemoveSuggestion(int count)
        {
            Drugs drug = new Drugs();
            IFormatter formatter = new BinaryFormatter();
            string path = drugs_path;
            Stream read = null;
            Stream write = new FileStream(path + "temp.txt", FileMode.Create, FileAccess.Write);

            try
            {
                if (File.Exists(path))
                    read = new FileStream(path + "Drugs.txt", FileMode.Open, FileAccess.Read);
                else
                    throw new CustomException("Cannot open drugs.txt");
            }
            catch(CustomException e)
            {
                MessageBox.Show(e.Message);
            }
           

            int i = 0;
            while (read.Position != read.Length)
            {
                i += 1;
                drug = (Drugs)formatter.Deserialize(read);
                if (i != count)
                {
                    formatter.Serialize(write, drug);
                }
            }
            read.Close();
            write.Close();

            File.Delete(path + "Drugs.txt");
            File.Move(path + "temp.txt", path + "Drugs.txt");

            dataGridView1.Rows.Clear();

            filereading();
        }

        private void disable_dataGridView()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                    dataGridView1.Rows[i].ReadOnly = true;
            }
        }

        void updatefiling(Drugs d, int count)
        {
            Drugs drug = new Drugs();
            IFormatter formatter = new BinaryFormatter();
            string path = drugs_path;
            Stream write = new FileStream(path + "temp.txt", FileMode.Create, FileAccess.Write);
            Stream read = null;

            try
            {
                if (File.Exists(path + "Drugs.txt"))
                    read = new FileStream(path + "Drugs.txt", FileMode.Open, FileAccess.Read);
                else
                    throw new CustomException("Cannot open Drugs.txt");
            }
            catch(CustomException e)
            {
                MessageBox.Show(e.Message);
            }
            int i = 0;
            while (read.Position != read.Length)
            {
                i += 1;
                drug = (Drugs)formatter.Deserialize(read);
                if (i != count)
                {
                    formatter.Serialize(write, drug);
                }
                else
                {
                    formatter.Serialize(write, d);
                }
            }
            read.Close();
            write.Close();

            File.Delete(path + "Drugs.txt");
            File.Move(path + "temp.txt", path + "Drugs.txt");

            dataGridView1.Rows.Clear();

            filereading();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (i == option)
                {
                    dataGridView1.Rows[i].Cells[0].ReadOnly = true;
                    dataGridView1.Rows[i].Cells[1].ReadOnly = false;
                    dataGridView1.Rows[i].Cells[3].ReadOnly = false;
                    dataGridView1.Rows[i].Cells[2].ReadOnly = false;
                }
                else
                {
                    //dataGridView1.Rows[0].ReadOnly = true;
                    dataGridView1.Rows[i].ReadOnly = true;
                }
            }
            btnupdate.Enabled = true;
            btnupdate.BackColor = Color.Black;

        }
        //Update Button
        private void button6_Click(object sender, EventArgs e)
        {
                Drugs d = new Drugs();
                d._drugType = dataGridView1.Rows[option].Cells[1].Value.ToString();
                d._drugName = dataGridView1.Rows[option].Cells[2].Value.ToString();
                d._drugStrenght = dataGridView1.Rows[option].Cells[3].Value.ToString();
                updatefiling(d, option + 1);
                txttb.Clear();
                btndelete.Visible = false;
                btnupdate.Visible = false;
            disable_dataGridView();
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        //Delete Button
        private void btndelete_Click(object sender, EventArgs e)
        {
                RemoveSuggestion(option + 1);
                txttb.Clear();
                btndelete.Visible = false;
                btnupdate.Visible = false;
            disable_dataGridView();
        }

        private void txttb_TextChanged(object sender, EventArgs e)
        {

        }
        //Submit Button
        private void button1_Click(object sender, EventArgs e)
        {
            int opt=-1;
            if (!string.IsNullOrEmpty(txttb.Text))
            {
                opt = Int32.Parse(txttb.Text);
                if (opt < (dataGridView1.RowCount) && opt > 0)
                {
                    btndelete.Visible = true;
                    btnupdate.Visible = true;
                    btnupdate.Enabled = false;
                    btnupdate.BackColor = Color.Silver;
                    option = Int32.Parse(txttb.Text);
                    option -= 1;
                    errorProvider1.Clear();
                }
                else
                {
                    txttb.Focus();
                    errorProvider1.SetError(txttb, "S_No cannot be greater than total rows and must be greater than zero!");
                }
            }
            else
            {
                txttb.Focus();
                errorProvider1.SetError(txttb, "S_No cannot be Null !");
            }
        }
    }
}
