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

namespace WindowsFormsApplication3
{
    public partial class signup : sample
    {
        public signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            secondpage sw = new secondpage();
            sw.ShowDialog();

            StreamWriter ss = File.AppendText("signup.txt");
            ss.Write("NAME=");
            ss.Write(textBox1.Text);
            ss.WriteLine("");
            ss.Write("FATHER NAME=");
            ss.Write(textBox2.Text);
            ss.WriteLine("");
            ss.Write("AGE=");
            ss.Write(textBox3.Text);
            ss.WriteLine("");
            ss.Write("CONTACT NO.=");
            ss.Write(textBox4.Text);
            ss.WriteLine("");
            ss.Write("EMAIL=");
            ss.Write(textBox5.Text);
            ss.WriteLine("");
            ss.Write("USERNAME=");
            ss.Write(textBox6.Text);
            ss.WriteLine("");
            ss.Write("PASSWORD=");
            ss.Write(textBox7.Text);
            ss.WriteLine("");
            ss.WriteLine("*********************************");
            ss.Close();
        }
    }
}
