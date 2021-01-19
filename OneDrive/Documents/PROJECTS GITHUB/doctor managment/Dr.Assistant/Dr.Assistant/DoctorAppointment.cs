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
using System.Net;
using System.Net.Mail;
using System.Web;

namespace OOP_PROJECT_WINDOW_FORM
{
    public partial class DoctorAppointment : Form
    {
        string Doctor_path;
        string Patient_path;

        string Doc_username;
        string patient_username1;
        string patient_username2;

        public DoctorAppointment()
        {
            InitializeComponent();
        }

        public DoctorAppointment(string Doc_username)
        {

            Doctor_path = First_Page.doc_path;
            Patient_path = First_Page.pat_path;
            
            this.Doc_username = Doc_username;

            InitializeComponent();
        }

        int readEmptyLines(string username, int opt)
        {
            string line;
            int count = 0;
            StreamReader sr = null;

                  //    MessageBox.Show(username);
            try
            {
                if(opt == 0)
                sr = new StreamReader(Doctor_path + username + ".txt");

                else
                sr = new StreamReader(Patient_path + username + ".txt");
            }
            catch { MessageBox.Show("Unable to Open File"); }

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

        
        void showPatientDetails1(string patient_username)
        {
            List<string> symptoms = new List<string>();
            int cnt = 0;
            int EmptyLines = readEmptyLines(patient_username, 1);

            StreamReader sr = null;
            try
            {
                if (File.Exists(Patient_path + patient_username + ".txt"))
                    sr = new StreamReader(Patient_path + patient_username + ".txt");
                else
                    throw new CustomException("Unable to Open Patient.txt");
            }
            catch(CustomException e) 
            { MessageBox.Show(e.Message); }

            string trash;
            string fname = sr.ReadLine();
            string lname = sr.ReadLine();

            txtName1.Text = fname + " " + lname;

            for (int i = 0; i < 2; ++i)
            {
                trash = sr.ReadLine();
            }
    
            txtAge1.Text = sr.ReadLine();

            txtGender1.Text = sr.ReadLine();

            while(true)
            {
                trash = sr.ReadLine(); 
                if( string.IsNullOrEmpty(trash))
                {
                    cnt += 1;
                    if(cnt == EmptyLines-1)
                    {
                        break;
                    }
                }
            }
            while(true)
            {
               if( ( trash = sr.ReadLine() ) == "Symptoms End") { break; }
            }
            txtDiagnosis1.Text = sr.ReadLine();

            sr.Close();
        }

        void showPatientDetails2(string patient_username)
        {
            int cnt = 0;
            int EmptyLines = readEmptyLines(patient_username, 1);

            StreamReader sr = null;
            try
            {
                if (File.Exists(Patient_path + patient_username + ".txt"))
                    sr = new StreamReader(Patient_path + patient_username + ".txt");
                else
                    throw new CustomException("Unable to Open Patient.txt");
            }
            catch(CustomException e)
            { MessageBox.Show(e.Message); }

            string trash;
            string fname = sr.ReadLine();
            string lname = sr.ReadLine();

            txtName2.Text = fname + " " + lname;

            for (int i = 0; i < 2; ++i)
            {
                trash = sr.ReadLine();
            }

            txtAge2.Text = sr.ReadLine();

            txtGender2.Text = sr.ReadLine();

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
            while (true)
            {
                if ((trash = sr.ReadLine()) == "Symptoms End") { break; }
            }
            txtDiagnosis2.Text = sr.ReadLine();
            sr.Close();
        }

        int searchPatient_DocFile()
        {
            txtAge1.Enabled =true ;
            txtAge2.Enabled = true;
            txtName1.Enabled = true;
            txtName2.Enabled = true;
            txtGender1.Enabled = true;
            txtGender2.Enabled = true;
            txtDiagnosis1.Enabled = true;
            txtDiagnosis2.Enabled = true;

            int EmptyLines;
            string line;
            int flag = 0;

            EmptyLines = readEmptyLines(this.Doc_username,0);

            StreamReader sr = null;

            try
            {
                if (File.Exists(Doctor_path + Doc_username + ".txt"))
                    sr = new StreamReader(Doctor_path + Doc_username + ".txt");
                else
                    throw new CustomException("Unable to Open Doctor.txt");
            }
            catch(CustomException e)
            { MessageBox.Show(e.Message); }

            if (EmptyLines == 1)
            {
                return 0;
            }
            else if (EmptyLines == 2)
            {
                flag = 1;
                while (true)
                {
                    line = sr.ReadLine();
                    if (string.IsNullOrEmpty(line))
                    {
                        break;
                    }
                }

                patient_username1 = sr.ReadLine();
                showPatientDetails1(patient_username1);
            }
            else
            {
                for (int i = 1; i < 3 ; ++i)
                {
                    flag = 2;
                    while (true)
                    {
                        line = sr.ReadLine();
                        if (string.IsNullOrEmpty(line))
                        {
                            break;
                        }
                    }

                    if (i == 1)
                    {
                        
                        patient_username1 = sr.ReadLine();
                        showPatientDetails1(patient_username1);
                    }
                    if (i == 2)
                    {
                        patient_username2 = sr.ReadLine();
                        showPatientDetails2(patient_username2);
                    }
                }
            }

            sr.Close();
            if (flag == 1)
                return 1;
            else
                return 2;
        }
        void manageTextBoxes()
        {
            int option;
            option = searchPatient_DocFile();
            if (option == 0)
            {
                lbl1.Text = "No Appointment Yet";
                lbl2.Text = "No Appointment Yet";

                btnPrescription1.Enabled = false;
                btnPrescription1.BackColor = Color.Silver;

                btnPrescription2.Enabled = false;
                btnPrescription2.BackColor = Color.Silver;

                btnView1.Enabled = false;
                btnView1.BackColor = Color.Silver;

                btnView2.Enabled = false;
                btnView2.BackColor = Color.Silver;

                btnDone1.Enabled = false;
                btnDone1.BackColor = Color.Silver;

                btnDone2.Enabled = false;
                btnDone2.BackColor = Color.Silver;

                btnVP1.Enabled = false;
                btnVP1.BackColor = Color.Silver;

                btnVP2.Enabled = false;
                btnVP2.BackColor = Color.Silver;
            }

            else if (option == 1)
            {
                lbl1.Text = "No Appointment Yet";
                btnPrescription2.Enabled = false;
                btnPrescription2.BackColor = Color.Silver;

                btnView2.Enabled = false;
                btnView2.BackColor = Color.Silver;

                btnDone2.Enabled = false;
                btnDone2.BackColor = Color.Silver;

                btnVP2.Enabled = false;
                btnVP2.BackColor = Color.Silver;
            }

            txtAge1.Enabled = false;
            txtAge2.Enabled = false;
            txtName1.Enabled = false;
            txtName2.Enabled = false;
            txtGender1.Enabled = false;
            txtGender2.Enabled = false;
            txtDiagnosis1.Enabled = false;
            txtDiagnosis2.Enabled = false;
        }

        void clearTextBoxes()
        {
            txtName1.Clear();
            txtName2.Clear();
            txtAge1.Clear();
            txtAge2.Clear();
            txtGender1.Clear();
            txtGender2.Clear();
            txtDiagnosis1.Clear();
            txtDiagnosis2.Clear();
        }

        private void DoctorAppointment_Load(object sender, EventArgs e) //load
        {
            manageTextBoxes();
        }

        private void btnPrescription1_Click(object sender, EventArgs e)
        {
            PrescriptionPage prescribe = new PrescriptionPage(this.Doc_username,this.patient_username1);
            prescribe.ShowDialog();
        }

        private void btnPrescription2_Click(object sender, EventArgs e)
        {
            PrescriptionPage prescribe = new PrescriptionPage(this.Doc_username, this.patient_username2);
            prescribe.ShowDialog();
        }

        bool isPrescriptionWritten(string patient_username,int no)
        {
            string path = First_Page.pres_path + patient_username + "_prescription.txt";

            if (File.Exists(path)) { return true; }
            else
            {
                if (no == 1)
                errorProvider1.SetError(btnPrescription1, "Please Write Prescription!!");
                else
                errorProvider1.SetError(btnPrescription2, "Please Write Prescription!!");

                return false;
            }
        }

        private void btnDone1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you have completed the assessment ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (isPrescriptionWritten(patient_username1, 1))
                {

                    errorProvider1.Clear();

                    StreamWriter sw = null;
                    StreamReader sr = null;

                    int EmptyLines;
                    EmptyLines = readEmptyLines(Doc_username, 0);

                    string line;  //useful string
                    try
                    {
                        sw = new StreamWriter(Doctor_path + "temp.txt");
                        sr = new StreamReader(Doctor_path + Doc_username + ".txt");
                    }
                    catch { MessageBox.Show("Unable to Open File"); }

                    while (true)
                    {
                        line = sr.ReadLine();
                        if (string.IsNullOrEmpty(line))  //first patient is written after one space
                        {
                            break;
                        }
                        sw.WriteLine(line);
                    }
                    line = sr.ReadLine();
                    while (true)
                    {
                        line = sr.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        sw.WriteLine(line);
                    }

                    sr.Close();
                    sw.Close();

                    File.Delete(Doctor_path + Doc_username + ".txt");
                    File.Move(Doctor_path + "temp.txt", Doctor_path + Doc_username + ".txt");

                    MessageBox.Show("Assessment done", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AssessmentDone done = new AssessmentDone(Patient_path, this.patient_username1);
                    done.ShowDialog();

                    clearTextBoxes();

                    manageTextBoxes();
                }
            }
        }

        private void btnDone2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you have completed the assessment ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (isPrescriptionWritten(patient_username2, 2))
                {
                    errorProvider1.Clear();

                    StreamReader sr = null;
                    StreamWriter sw = null;
                    string line;
                    int count = 0;

                    try
                    {
                        sw = new StreamWriter(Doctor_path + "temp.txt");
                        sr = new StreamReader(Doctor_path + Doc_username + ".txt");
                    }
                    catch { MessageBox.Show("Unable to Open File"); }

                    while (true)
                    {
                        line = sr.ReadLine();
                        if (string.IsNullOrEmpty(line))   //beacause second patient is written after 2 spaces
                        {
                            count += 1;
                            if (count == 2)
                            {
                                break;
                            }
                        }
                        sw.WriteLine(line);
                    }

                    line = sr.ReadLine();

                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(line);
                    }

                    sr.Close();
                    sw.Close();

                    File.Delete(Doctor_path + Doc_username + ".txt");
                    File.Move(Doctor_path + "temp.txt", Doctor_path + Doc_username + ".txt");


                    AssessmentDone done = new AssessmentDone(Patient_path, this.patient_username2);
                    done.ShowDialog();

                    clearTextBoxes();

                    manageTextBoxes();
                }
            }
        }//Done 2 bracket

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            doctorFunctions df = new doctorFunctions(this.Doc_username);
            df.ShowDialog();
            this.Close();
        }

        private void btnView1_Click(object sender, EventArgs e)
        {
            PatientRecords pr = new PatientRecords(patient_username1);
            pr.ShowDialog();
        }

        private void btnView2_Click(object sender, EventArgs e)
        {
            PatientRecords pr = new PatientRecords(patient_username2);
            pr.ShowDialog();
        }

        private void btnVP2_Click(object sender, EventArgs e)
        {
            ViewPrescription vp = new ViewPrescription(this.patient_username2);
            vp.ShowDialog();
        }

        private void btnVP1_Click(object sender, EventArgs e)
        {
            ViewPrescription vp = new ViewPrescription(this.patient_username1);
            vp.ShowDialog();
        }
    }
}
