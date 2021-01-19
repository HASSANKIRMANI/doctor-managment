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
using System.Xml.Serialization;

namespace OOP_PROJECT_WINDOW_FORM
{
    public partial class PatientRecords : Form
    {

        string username;                        //To save argument of constructor
        string path;
        string firstname;

        string date_time;                       //To save date_time from file Writteb after 1st blank line
        List<string> l = new List<string>();    //To save list of symptoms from file till Systoms End string
        string disease_predicted;               //To save disease_predicted from file
        string doctor_suggested;                //To save doctor_suggested from file


        static int no_rows;

        public PatientRecords()
        {
            InitializeComponent();
        }
        public PatientRecords(string username)
        {

            this.username = username;
            this.path = First_Page.pat_path + username + ".txt"; //Noman
            InitializeComponent();
        }

        //LOAD
        private void PatientRecords_Load(object sender, EventArgs e)
        {
            no_rows = 0;
            lblNote.Visible = false;
            constructDataGridView();
           
        }

        //constructing basic structure of datagridview
        private void constructDataGridView()
        {
            int empty_lines = readEmptyLines();

            //Adding columns

            dataGridView1.BorderStyle = BorderStyle.Fixed3D;  //design setting
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Coral;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Disable Resizing
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;


            dataGridView1.ReadOnly = true;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Date";
            dataGridView1.Columns[1].Name = "Disease Predicted";
            dataGridView1.Columns[2].Name = "Doctor Proposed";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (readEmptyLines() > 1) //call only when atleast once diagnose in done
            {
                filereading();

                //Adding button
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = @"Symptoms";
                btn.Name = "btn";
                btn.Text = "CLICK ME";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
            }
            else
            {
                lblNote.Visible = true;
                lblNote.Text = "You are a fresh user, Please first go for diagnosis or appointment booking";
            }
        }

        int readEmptyLines() //reading empty lines in patient file ( emptyline - 1 = number of appointment uptill now)
        {
            string line;
            int count = 0;
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(this.path);
            }
            catch { MessageBox.Show("Unable to Open Patient.txt"); }

            firstname = sr.ReadLine();
            patientlbl.Text = firstname + "'S" + " Medical Records";

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


        private void filereading()
        {
            int empty_lines = readEmptyLines();


            StreamReader sr = null;

            try
            {
                sr = new StreamReader(path);
            }
            catch { MessageBox.Show("Unable to open Patient.txt"); }

            string line;

            for (int i = 0; i < empty_lines - 1; i++)
            {
                while (true)
                {

                    line = sr.ReadLine();
                    if (string.IsNullOrEmpty(line))
                    {
                        break;
                    }
                }
                date_time = sr.ReadLine();

                while (true)
                {
                    if ((line = sr.ReadLine()) == "Symptoms End")
                    {
                        break;
                    }
                    l.Add(line);
                }
                disease_predicted = sr.ReadLine();
                doctor_suggested = sr.ReadLine();

                AddRow(); //adding row
                no_rows += 1;
            }
            dataGridView1.Rows[no_rows - 1].DefaultCellStyle.BackColor = Color.Chocolate; //changing color of latest record

            sr.Close();
        }

        //Adding row in datagridview
        void AddRow()
        {
            //Add row(one row added at a time)

            ArrayList row = new ArrayList();
            row.Add(date_time);
            row.Add(disease_predicted);
            row.Add(doctor_suggested);
            dataGridView1.Rows.Add(row.ToArray());

        }

        //Reading symptoms from patient file so that it can be added into the button
        void readSymptoms(int symptoms_line)
        {
            string trash;
            l.Clear();

            StreamReader sr = null;

            try
            {
                if (File.Exists(path))
                    sr = new StreamReader(path);
                else
                    throw new CustomException("Unable to open Patient.txt");
            }
            catch(CustomException e) 
            { MessageBox.Show(e.Message); }

            string line;
            int i = 0;
            while (i < symptoms_line)
            {
                line = sr.ReadLine();

                if (string.IsNullOrEmpty(line))
                {
                    i = i + 1;
                }
            }
            trash = sr.ReadLine(); //reading date

            while (true)
            {
                if ((line = sr.ReadLine()) == "Symptoms End")
                {
                    break;
                }
                l.Add(line);
            }
            sr.Close();

        }


        //Button 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int empty_lines = readEmptyLines();
            var senderGrid = (DataGridView)sender;
            for (int i = 1; i < empty_lines; i++)
            {
                try
                {
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        if (e.ColumnIndex == 3 && e.RowIndex == i - 1)
                        {
                            readSymptoms(i);
                        }

                        Symptomslb.Items.Clear();
                        Symptomslb.Items.Add("Symptoms");
                        Symptomslb.Items.Add(" ");

                        foreach (string s in l)
                            Symptomslb.Items.Add(s);
                    }
                }
                catch 
                {

                }
            }

        }

        //back button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }
}
