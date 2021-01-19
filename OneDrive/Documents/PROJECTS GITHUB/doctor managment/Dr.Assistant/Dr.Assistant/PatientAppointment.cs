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
using System.Net;
using System.Net.Mail;
using System.Web;

namespace OOP_PROJECT_WINDOW_FORM
{
    public partial class PatientAppointment : Form
    {
        string username;

        doctor d = null;

        bool callViewAppointment = false;  // true -> fix appointment + show appointment details
                                           // false -> only show appointment details 
        string patient_path;

        string doc_path;

        public PatientAppointment()
        {
            InitializeComponent();
        }

        public PatientAppointment(string username)
        {
            doc_path = First_Page.doc_path;

            patient_path = First_Page.pat_path;

            this.username = username;
            InitializeComponent();
        }

        public PatientAppointment(string username, bool callViewAppointment)
        {
            doc_path = First_Page.doc_path;

            patient_path = First_Page.pat_path;

            this.username = username;
            this.callViewAppointment = callViewAppointment;
            InitializeComponent();
        }

        void PatientAppointment_Load(object sender, EventArgs e)
        {
            doctor doc;
            //Indicating that appointment has been fixed and that no diagnosis can be done untill the Doctor prescribes the medicine

            if (this.callViewAppointment)
            {
                IViewAppointment view = new Appointment(this.username);
                doc = view.viewAppointment(patient_path,doc_path);
                
                if(doc == null)
                {
                    lbl1.Text = "Note: No Appointment Fixed Yet,First go to Disease Diagnose or Book an Appointment";
                    btnPrescription.Enabled = false;
                }
                else
                {
                    txtAge.Text = doc._Age.ToString();
                    txtName.Text = "Dr. " + doc._FirstName + " " + doc._LastName;
                    txtPhone.Text = doc._PhoneNo;
                    txtFees.Text = doc._Fee.ToString();
                    txtSpeciality.Text = doc._Speciality;
                }
            }
            else
            {
                
                IFixAppointment fix = new Appointment(this.username); //interface
                doc = fix.fixAppointment(patient_path, doc_path);

                if (doc == null)
                {
                    btnPrescription.Enabled = false;
                    lbl1.Text = "We were unable to find a suitable doctor in our System, Please comeback later";
                }
                else
                {
                    txtAge.Text = doc._Age.ToString();
                    txtName.Text = "Dr. " + doc._FirstName + " " + doc._LastName;
                    txtPhone.Text = doc._PhoneNo;
                    txtFees.Text = doc._Fee.ToString();
                    txtSpeciality.Text = doc._Speciality;

                    d = doc;
                    backgroundWorker1.RunWorkerAsync();

                }
            }
            
            txtName.Enabled = false;
            txtAge.Enabled = false;
            txtFees.Enabled = false;
            txtSpeciality.Enabled = false;
            txtPhone.Enabled = false;
            lblNote.Visible = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            SendingNotifications notify = new SendingNotifications(this.username, d);
            notify.ShowDialog();
        }

        //Prescription will only be shown when assessment is completed by doctor

        bool isAssessmentCompleted() //to check wheather the user already have a appointment or not
        {                           //for that checking username in the doctor file 
            StreamReader user = null;
            StreamReader sr = null;

            try
            {
                user = new StreamReader(doc_path + "usernames.txt");
            }
            catch { MessageBox.Show("Unable to Open Usernames.txt"); }

            string users;
            string line;

            while ((users = user.ReadLine()) != null)//reading usernames of doc from username files
            {
                try
                {
                    if (File.Exists(doc_path + users + ".txt"))
                        sr = new StreamReader(doc_path + users + ".txt");
                    else
                        throw new CustomException(user + ".txt");
                }
                catch(CustomException e) 
                { MessageBox.Show(e.Message); }

                while (true)
                {
                    line = sr.ReadLine();
                    if (string.IsNullOrEmpty(line))  //breaking at first empty line after general info
                    {
                        break;
                    }
                }
                while ((line = sr.ReadLine()) != null) //checking in appointment names in doc file
                {
                    if (this.username == line)
                    {
                        sr.Close();
                        user.Close();
                        return false;
                    }
                }//inner while
                sr.Close();
            }//outer while

            user.Close();
            return true;

        }

        //View Prescription button
        private void button1_Click(object sender, EventArgs e)
        {
            if (isAssessmentCompleted()) //checking wheather assesment is completed or not
            {
                ViewPrescription vp = new ViewPrescription(this.username);
                vp.ShowDialog();
            }
            else
            {
                lblNote.Visible = true;
            }
        }

        //back button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientFunctions pf = new patientFunctions(this.username);
            pf.ShowDialog();
            this.Close();
        }

        //Exit button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure, You Want to Exit", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}
