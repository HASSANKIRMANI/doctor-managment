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
    public partial class Admin : Form
    {
        //To store username
        string Admin_Username;
        bool voice = false;

        public Admin()
        {
            InitializeComponent();
        }

        //Overloaded Constructor
        public Admin(string username)
        {
            Admin_Username = username;
            InitializeComponent();
        }

        public Admin(bool voice)
        {
            this.voice = voice;
            InitializeComponent();
        }

        void Jarvis()
        {
            string call = "Welcome Back Sir";

            SpeechSynthesizer reader;
            reader = new SpeechSynthesizer(); //create new object
            reader.Rate = -3;
            reader.Volume = 100;
            reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Senior);
            reader.SpeakAsync(call);
        }

        //Load
        private void Admin_Load(object sender, EventArgs e)
        {
            if (voice) VoiceCalling.RunWorkerAsync();
        }
        private void VoiceCalling_DoWork(object sender, DoWorkEventArgs e)
        {
            Jarvis();
        }

        //Doctors list
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctors_Info di = new Doctors_Info();
            di.ShowDialog();
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


        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search_doctor search = new Search_doctor();
            search.ShowDialog();
            this.Close();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            this.Hide();
            Approve_drugs approve = new Approve_drugs();
            approve.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.Beep();
            this.Hide();
            First_Page fp = new First_Page();
            fp.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You Want to LogOut", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                First_Page first = new First_Page();
                first.ShowDialog();
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
