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
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.CompilerServices;

namespace OOP_PROJECT_WINDOW_FORM
{   
    public partial class ReportGenerator : Form
    {

        List<string> symptoms = new List<string>();
        string date;

        string username; //patient username
        string patient_path;

        Patient patient = new Patient(); 
        Prescription prescribe = new Prescription();  // for reading from prescription file
        Diseasess disease = new Diseasess();

        public ReportGenerator()
        {
            patient_path = First_Page.pat_path;
            InitializeComponent();
        }

        public ReportGenerator(string username)
        {
            this.username = username;
            patient_path = First_Page.pat_path + this.username + ".txt";
            InitializeComponent();
        }

        private void ReportGenerator_Load(object sender, EventArgs e)
        {
            lblDisease.Visible = false;
            lblError.Visible = true;
            //for writing in textbox and list box

            if (readEmptyLines(patient_path) > 1)
            {
                constructBasicInfo();
                DisableTextBoxes();
                constructDataGridView();    //for writing in datagridbox
            }
            else
            {
                lblDisease.Visible = true;
                Printbtn.Enabled = false;
                lblDisease.Text = "You are a fresh user, Please first go for diagnosis or appointment booking";
            }
            constructDataGridView(6);
        }

        int readEmptyLines(string path)
        {
            string line;
            int count = 0;
            StreamReader sr = null;

            try
            {
                if (File.Exists(path))
                    sr = new StreamReader(path);
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

        int readno_of_drugs(string path)
        {
            StreamReader sr = null;
            int cnt=0;
            string line=null;
            try
            {
                if (File.Exists(path))
                    sr = new StreamReader(path);
                else
                    throw new CustomException("Cannot open drugs.txt");
            }
            catch(CustomException e)
            {
               MessageBox.Show(e.Message);
            }
            while(true)
            {
                line = sr.ReadLine();
                if(line=="drug")
                {
                    cnt+=1;
                }
                if (string.IsNullOrEmpty(line))
                    break;
            }
            return cnt;
        }

        void DisableTextBoxes()
        {
            FnameTb.Enabled = false;
            LnameTb.Enabled = false;
            AgeTb.Enabled = false;
            PhoneNoTb.Enabled = false;
            GenderTb.Enabled = false;
            AddressTb.Enabled = false;

        }

        private void constructBasicInfo()
        {
            filereading1();
        }

        private void constructDataGridView(int columns)
        {

            string path = First_Page.pres_path + this.username + "_prescription.txt";

            //STYLING OF DATAGRIDVIEW
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Coral;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView2.ColumnHeadersHeight = 30;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //Adding columns
            dataGridView2.ReadOnly = true;
            dataGridView2.ColumnCount = columns;
            dataGridView2.Columns[0].Name = "Drug Type";
            dataGridView2.Columns[1].Name = "Drug Name";
            dataGridView2.Columns[2].Name = "Drug Strength";
            dataGridView2.Columns[3].Name = "Drug Dose";
            dataGridView2.Columns[4].Name = "Drug Duration";
            dataGridView2.Columns[5].Name = "Drug Advice";
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (File.Exists(path))
            {
                lblError.Visible = false;
                filereading(path);
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Doctor Has Not Completed Your Assessment Yet, Please Comeback Later.";
            }
        }
        private void filereading1()
        {
          
            int cnt=0;
            string line = null;

            StreamReader sr = null;
            try
            {
               sr = new StreamReader(patient_path);
            }
            catch { MessageBox.Show("Unable to Open Patient.txt"); }

            patient._FirstName = sr.ReadLine();
            patient._LastName = sr.ReadLine();

            for (int i = 0; i < 2; i++)
                sr.ReadLine();

            patient._Age = Int32.Parse(sr.ReadLine());
            patient._Gender = sr.ReadLine();
            patient._PhoneNo = sr.ReadLine();
            patient._Address = sr.ReadLine();

            int empty_lines = readEmptyLines(patient_path);

            while(true)
            {
                line=sr.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    cnt += 1;
                    if (cnt == (empty_lines - 1))
                    {
                        break;
                    }
                }
            }

            date =sr.ReadLine();

            while (true)
            {
                line = sr.ReadLine();
                if(line == "Symptoms End")
                {
                    break;
                }
                symptoms.Add(line);
            }
            
            disease._disease_predicted = sr.ReadLine();
            disease._doctor_suggest = sr.ReadLine();

            sr.Close(); 

            foreach (string s in symptoms)
            {
                listBox1.Items.Add(s);
            }
            addtext_boxes();

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

            //Adding column
            dataGridView1.ReadOnly = true;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Date";
            dataGridView1.Columns[1].Name = "Disease Predicted";
            dataGridView1.Columns[2].Name = "Doctor Proposed";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            AddRow();

        }

        void addtext_boxes()
        {
            dateTb.Text = DateTime.Today.ToString();
            FnameTb.Text = patient._FirstName;
            LnameTb.Text = patient._LastName;
            AgeTb.Text = patient._Age.ToString();
            GenderTb.Text = patient._Gender;
            PhoneNoTb.Text = patient._PhoneNo;
            AddressTb.Text = patient._Address;
        }



        void AddRow()
        {
            ArrayList row = new ArrayList();
            row.Add(date);
            row.Add(disease._disease_predicted);
            row.Add(disease._doctor_suggest);
            dataGridView1.Rows.Add(row.ToArray());
        }

        void AddRow(Prescription prescibe)
        {
            ArrayList row = new ArrayList();
            row.Add(prescribe._drugType);
            row.Add(prescribe._drugName);
            row.Add(prescribe._drugStrenght);
            row.Add(prescribe._drugDose);
            row.Add(prescribe._drugDuration);
            row.Add(prescribe._drugAdvice);

            dataGridView2.Rows.Add(row.ToArray());
        }

        void filereading(string path)
        {
            Stream read = null;
            IFormatter formatter = new BinaryFormatter();
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
                
            read.Position = 0;

            while (read.Position != read.Length)
            {
                prescribe = (Prescription)formatter.Deserialize(read);
                AddRow(prescribe);
            }

            read.Close();
        }




        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }


        Bitmap bmp;
        private void Printbtn_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bmp = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bmp);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientFunctions pf = new patientFunctions(this.username);
            pf.ShowDialog();
            this.Close();
        }
    }
}
