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
    public partial class secondpage : sample
    {
        public secondpage()
        {
            InitializeComponent();
        }

        private void secondpage_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            if (usertext.Text == "") { show("USERNAME IS MANDATORY", "Error"); }
            if (passtext.Text == "") { show("PASSWORD IS MANDATORY", "Error"); }
            if (usertext.Text == "admin")
            {
                if (passtext.Text == "admin123")
                {
                    this.Hide();
                    user uw = new user();
                    uw.ShowDialog();
                }
                else
                {
                    MessageBox.Show("INCORRECT  LOGIN");
                }
            }
        }
        public static void show(string msg, string type)
        {
            if (type == "success")
            {
                MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (type == "Error")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter txt=new StreamWriter("C:\\Users\\MY PC\\Desktop\\hassan\\OOP PROJECT\\New folder\\login.txt");
            txt.Write(usertext.Text);
            txt.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form ff = new Form();
            ff.ShowDialog();

        }
    }
}
