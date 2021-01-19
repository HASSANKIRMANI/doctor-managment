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

namespace OOP_PROJECT_WINDOW_FORM
{
    public partial class Search_doctor : Form
    {

        string doc_path;

        public Search_doctor()
        {
            doc_path = First_Page.doc_path;
            InitializeComponent();
        }
        //Adding doctor names in the combo box
        private void Search_doctor_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Text = DateTime.Now.ToString();

            string path = doc_path + "usernames.txt";

            string[] docs = File.ReadAllLines(path);

            foreach (string doc in docs)
                comboUsername.Items.Add(doc);

            EnableTextBoxes();
        }

        void EnableTextBoxes()
        {
            txtfname.Enabled = false;
            txtlname.Enabled = false;
            txtuname.Enabled = false;
            txtpassword.Enabled = false;
            txtage.Enabled = false;
            txtgender.Enabled = false;
            txtspeciality.Enabled = false;
            txtphno.Enabled = false;
            txtAddress.Enabled = false;
            txtposcode.Enabled = false;
            txtfee.Enabled = false;
            txtdescription.Enabled = false;
            label14.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Search button
        private void button2_Click(object sender, EventArgs e)
        {
            string username = comboUsername.Text;
            if (string.IsNullOrEmpty(username))
            {
                comboUsername.Focus();
                errorProvider1.SetError(comboUsername, "Select one of the Username to Proceed !");
            }
            else
            {
                errorProvider1.Clear();

                string path = doc_path + username + ".txt";

                StreamReader sr = null;
                try
                {
                    if (File.Exists(path))
                        sr = new StreamReader(path);
                    else
                        throw new CustomException("ERROR OPENING FILE");
                }
                catch (CustomException message)
                {
                    MessageBox.Show(message.Message, "Error");
                }

                txtfname.Text = sr.ReadLine();
                txtlname.Text = sr.ReadLine();
                txtuname.Text = sr.ReadLine();
                txtpassword.Text = sr.ReadLine();
                txtage.Text = sr.ReadLine();
                txtgender.Text = sr.ReadLine();
                txtspeciality.Text = sr.ReadLine();
                txtphno.Text = sr.ReadLine();
                txtAddress.Text = sr.ReadLine();
                txtposcode.Text = sr.ReadLine();
                txtfee.Text = sr.ReadLine();
                txtdescription.Text = sr.ReadLine();

                sr.Close();
                label14.Visible = true;
                label14.Text = "DR. " + txtfname.Text + " " + txtlname.Text;
            }

        }

        //for button in the side panel
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.ShowDialog();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Doctors_Info di = new Doctors_Info();
            di.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Tablets at = new Add_Tablets();
            at.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Tablets vt = new View_Tablets();
            vt.ShowDialog();
            this.Close();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            this.Hide();
            Approve_drugs approve = new Approve_drugs();
            approve.ShowDialog();
            this.Close();
        }

    }
}