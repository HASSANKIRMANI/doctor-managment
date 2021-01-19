using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace OOP_PROJECT_WINDOW_FORM
{
    public partial class ViewPrescription : Form
    {

        string patient_username;
        string path;

        Prescription prescribe = new Prescription();

        public ViewPrescription()
        {
            InitializeComponent();
        }
        public ViewPrescription(string patient_username)
        {
            this.patient_username = patient_username;
            path = First_Page.pres_path + this.patient_username + "_prescription.txt";
            InitializeComponent();
        }
        private void ViewPrescription_Load(object sender, EventArgs e)
        {
            constructDataGridView();
        }

        private void constructDataGridView()
        {

            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Coral;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ReadOnly = true;

            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[0].Name = "Drug Type";
            dataGridView1.Columns[1].Name = "Drug";
            dataGridView1.Columns[2].Name = "Drug strength";
            dataGridView1.Columns[3].Name = "Drug Dose";
            dataGridView1.Columns[4].Name = "Drug Duration";
            dataGridView1.Columns[5].Name = "Drug Advice";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (File.Exists(path))
            {
                filereading();
            }
       
        }

        private void filereading()
        {
            Stream read = null;
            IFormatter formatter = new BinaryFormatter();
            try
            {
                if (File.Exists(path))
                    read = new FileStream(path, FileMode.Open, FileAccess.Read);
                else
                    throw new CustomException("Cannot open File");
            }
            catch(CustomException e)
            {
                MessageBox.Show(e.Message);
            }

            read.Position = 0;

            while (read.Position != read.Length)
            {
                prescribe = (Prescription)formatter.Deserialize(read);
                AddRow();
            }
            read.Close();

        }

        //Adding row in the data grid view
        void AddRow()
        {
            //Add row
            ArrayList row = new ArrayList();
            row.Add(prescribe._drugType);
            row.Add(prescribe._drugName);
            row.Add(prescribe._drugStrenght);
            row.Add(prescribe._drugDose);
            row.Add(prescribe._drugDuration);
            row.Add(prescribe._drugAdvice);

            dataGridView1.Rows.Add(row.ToArray());

        }
        
        //Back button   
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
