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
    public partial class doctorFunctions : Form
    {
        private string username;
        bool voice = false;

        public doctorFunctions()
        {
            InitializeComponent();
        }

        public doctorFunctions(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        string readName()
        {
            string path = First_Page.doc_path + this.username + ".txt";

            StreamReader sr = new StreamReader(path);

            string fname = sr.ReadLine();
            string lname = sr.ReadLine();

            sr.Close();
            string name = fname + " " + lname;
            return name;
        }

        void Jarvis(string name)
        {
            string call = "Welcome" + name;

            SpeechSynthesizer reader;
            reader = new SpeechSynthesizer(); //create new object
            reader.Rate = -3;
            reader.Volume = 100;
            reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Senior);
            reader.SpeakAsync(call);
        }

        public doctorFunctions(string username,bool voice)
        {
            this.username = username;
            this.voice = voice;

            InitializeComponent();

          
        }

        private void doctorFunctions_Load(object sender, EventArgs e)
        {
            if(voice) backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string name = readName();
            Jarvis(name);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewInfo view = new viewInfo(username);
            view.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You Want to Exit", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure, You Want to LogOut", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                First_Page first = new First_Page();
                first.ShowDialog();
                this.Close();
            }
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorAppointment da = new DoctorAppointment(this.username);
            da.ShowDialog();
            this.Close();
        }

        private void btnSuggest_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuggestDrugs suggest = new SuggestDrugs(this.username);
            suggest.ShowDialog();
            this.Close();
        }

        private void btnInfo_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            viewInfo view = new viewInfo(username);
            view.ShowDialog();
            this.Close();
        }


    }
}
