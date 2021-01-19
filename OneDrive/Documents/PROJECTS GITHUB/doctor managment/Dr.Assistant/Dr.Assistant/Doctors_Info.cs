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
using System.Net;

namespace OOP_PROJECT_WINDOW_FORM
{
    public partial class Doctors_Info : Form
    {
        static int i = 1;
        string path;
        public Doctors_Info()
        {
            path = First_Page.doc_path;
            InitializeComponent();
        }
        private void Doctors_Info_Load(object sender, EventArgs e)
        {
            i= 1;
            textBox1.Enabled = false;
            textBox1.Text = DateTime.Now.ToString();
            constructDataGridView();
        }

        private void constructDataGridView()
        {
            //Changing color of header column
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Coral;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter; 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ReadOnly = true;
            //Adding columns
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ReadOnly = true;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[0].Name = "S_No";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[1].Name = "UserName";
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[2].Name = "Doctors";
            dataGridView1.Columns[3].Width = 245;
            dataGridView1.Columns[3].Name = "Speciality";
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            filereading();
        }

        private void filereading()
        {
            string user = null;
            string Name = null;
            string username = null;
            string speciality = null;


            StreamReader sr1=null;
            try
            {
                if (File.Exists(path + "usernames.txt"))
                    sr1 = new StreamReader(path + "usernames.txt");
                else
                    throw new CustomException("Cannot open Doctor Info !");
            }
            catch(CustomException e)
            {
                MessageBox.Show(e.Message);
            }
            

            while(true)
            {

                user = sr1.ReadLine();
                if(user==null)
                {
                    break;
                }
                StreamReader sr2=null;
                try
                {
                    if (File.Exists(path + user + ".txt"))
                        sr2 = new StreamReader(path + user + ".txt");
                    else
                        throw new CustomException("Cannot open Second Doctor Info");
                }
                catch(CustomException e)
                {
                    MessageBox.Show(e.Message);
                }
                Name = "DR." + sr2.ReadLine() + " " + sr2.ReadLine();
                username = sr2.ReadLine();
                for (int i = 0; i <= 2; i++)
                    sr2.ReadLine();
                speciality= sr2.ReadLine();

                AddRow(i , username ,  Name , speciality);
                i += 1;
            }
        }

        void AddRow(int i , string username , string line , string speciality)
        {
            ArrayList row = new ArrayList();
            row.Add(i);
            row.Add(username);
            row.Add(line);
            row.Add(speciality);
            dataGridView1.Rows.Add(row.ToArray());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search_doctor search = new Search_doctor();
            search.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Tablets at = new Add_Tablets();
            at.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }
}
