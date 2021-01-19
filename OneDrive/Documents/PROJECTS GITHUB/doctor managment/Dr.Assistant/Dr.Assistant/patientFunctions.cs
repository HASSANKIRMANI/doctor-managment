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
using System.Speech.Synthesis;

namespace OOP_PROJECT_WINDOW_FORM
{
    public partial class patientFunctions : Form
    {
        private string username;
        bool voice = false;

        public patientFunctions()
        {
            InitializeComponent();
        }

        public patientFunctions(string username)
        {
            this.username = username;
            InitializeComponent();
        }
        //Bool to check whether it is // true -> fix appointment + show appointment details
                                      // false -> only show appointment details 
        public patientFunctions(string username,bool voice)
        {
            this.username = username;
            this.voice = voice;

            InitializeComponent();
            //Will call do work function
            VoiceCalling.RunWorkerAsync();
        }

        //LOAD
        private void patientFunctions_Load(object sender, EventArgs e)
        {
            if (isAppointmentPresent())
            {
                btnBook.Enabled = false;
                btnBook.BackColor = Color.Silver;
                lblerror2.Visible = true;
                lblerror2.Text = "Appointment Already Fixed";
            }
            else
            {
                btnDiagnosis.BackColor = Color.Black;
                btnBook.BackColor = Color.Black;
                lblerror2.Visible = false;
            }
        }
        //Background worker Event DoWork
        private void VoiceCalling_DoWork(object sender, DoWorkEventArgs e)
        {
            string name = readName();
            Jarvis(name);
        }
        //To read the name of the user from his .txt file
        string readName()
        {
            string path = First_Page.pat_path + this.username + ".txt";

            StreamReader sr = new StreamReader(path);

            string fname = sr.ReadLine();
            string lname = sr.ReadLine();

            sr.Close();
            string name = fname + " " + lname;
            return name;
        }
        //To call out the name with the help of speech synthesizer
        void Jarvis(string name)
        {
            string call = "Welcome" + name;

            SpeechSynthesizer reader;
            reader = new SpeechSynthesizer(); //create new object
            reader.Rate = -3;
            reader.Volume = 100;
            reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            reader.SpeakAsync(call);
        }
        //Called from main to enable to disable buttons
        bool isAppointmentPresent() //to check wheather the user already have a appointment or not
        {                           //for that checking username in the doctor file 

            string doc_path = First_Page.doc_path;

            StreamReader user = null;
            StreamReader sr = null;

            try
            {
                if (File.Exists(doc_path + "usernames.txt"))
                    user = new StreamReader(doc_path + "usernames.txt");
                else
                    throw new CustomException("Unable to Open Usernames.txt");
            }
            catch(CustomException e)
            { MessageBox.Show(e.Message); }

            string users;
            string line;

            while ( (users = user.ReadLine())!= null)//reading usernames of doc from username files
            {
                try
                {
                    sr = new StreamReader(doc_path + users + ".txt");
                }
                catch { MessageBox.Show("Unable to Open patient.txt");
                    return false;
                }

                while(true)
                {
                    line = sr.ReadLine();  
                    if(string.IsNullOrEmpty(line))  //breaking at first empty line after general info
                    {
                        break;
                    }
                }

                while ( ( line= sr.ReadLine() )!= null) //checking appointment names in doc file
                {
                    if(this.username == line)
                    {
                        sr.Close();
                        user.Close();
                        return true;
                    }
                }//inner while

                sr.Close();

            }//outer while

            user.Close();
            return false;

        }
        //EXIT
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You Want to LogOut", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //LOGOUT
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You Want to LogOut", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                First_Page first = new First_Page();
                first.ShowDialog();
                this.Close();
            }
        }

        //Side panel buttons
        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewInfo i = new viewInfo(this.username);
            i.ShowDialog();
            this.Close();
        }

        private void btnDiagnosis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diagnosis d = new Diagnosis(username);
            d.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientAppointment pa = new PatientAppointment(username, true);
            pa.ShowDialog();
            this.Close();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            PatientRecords pr = new PatientRecords(username);
            pr.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookAppointment book = new BookAppointment(this.username);
            book.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportGenerator report = new ReportGenerator(this.username);
            report.ShowDialog();
            this.Close();
        }
    }
}
