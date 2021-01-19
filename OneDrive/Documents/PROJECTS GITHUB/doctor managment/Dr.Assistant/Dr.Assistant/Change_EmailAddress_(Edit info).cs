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
    public partial class ChangeEmail : Form
    {
        string email =  null;

        string username;
        string randomNumber;
        string finalString;

        string Patient_path;
        string Doctor_path;

        public ChangeEmail()
        {
            InitializeComponent();
        }
        public ChangeEmail(string username)
        {
            this.username = username;

            Doctor_path = First_Page.doc_path;

            Patient_path = First_Page.pat_path;

            InitializeComponent();
        }

        bool isTextBoxEmpty(string text)
        {
            return (string.IsNullOrEmpty(text));
        }

        int count = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = "00 : " + count.ToString();

            if (count == 0)
            {
                timer1.Stop();

                lblPin.Text = "";
                lblTimer.Text = "";

                this.Close();
                this.Hide();
                ChangeEmail change = new ChangeEmail(this.username);
                change.ShowDialog();       
            }
            count -= 1;
        }
        //Send Pin
        private void button1_Click(object sender, EventArgs e)
        {
            email = txtEmail.Text;
            Patient patient = new Patient();

            try
            {
                if (patient.isValidEmail(email))
                {
                    if (txtCaptcha.Text == finalString)
                    {
                        lblEmail.Text = "";

                        Random rnd = new Random();
                        randomNumber = (rnd.Next(1000, 9999)).ToString();

                        EmailProgressing check = new EmailProgressing(email, randomNumber);
                        check.ShowDialog();

                        timer1.Start();

                        txtEmail.Enabled = false;
                        txtCaptcha.Enabled = false;

                        txtPin.Enabled = true;

                        btnSend.Enabled = false;
                        btnSend.BackColor = Color.Silver;
                    }
                    else
                    {
                        email = null;
                        lblCaptcha.Text = "Wrong Captcha";
                    }
                }
                else
                {
                    throw new CustomException("Invalid Email");
                }
            }
            catch(CustomException msg)
            {
                lblEmail.Text = msg.Message; 
            }
        }

        private void loadCaptchaImage()
        {
            var chars = "ABCDEFGHIJLMNPQRSTUVWXYZabcdefghijlmnpqrstuvwxyz0123456789";
            var stringChars = new char[6];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            finalString = new String(stringChars);

            var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("Chiller", 40, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(finalString.ToString(), font, Brushes.Black, new Point(0, 0));
            pictureBox1.Image = image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadCaptchaImage();
            txtPin.Enabled = false;
            labelPin.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadCaptchaImage();
        }

        private void txtCaptcha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        int editEmail(string email)
        {
            string line;

            int limit = 0;
            StreamWriter sw = null;
            StreamReader sr = null;

            if (First_Page.opt1 == 0)
            {
                limit = 12;
                try
                {
                    if (File.Exists(Doctor_path + username + ".txt"))
                    {
                        sr = new StreamReader(Doctor_path + username + ".txt");
                    }
                    else
                    {
                        throw new CustomException("Unable to Open Doctor File");
                    }
                    sw = new StreamWriter(Doctor_path + "temp.txt");
                }
                catch (CustomException msg)
                {
                    MessageBox.Show(msg.Message);
                    return 0;
                }
            }

            else
            {
                limit = 9;
                try
                {
                    if (File.Exists(Patient_path + this.username + ".txt"))
                    {
                        sr = new StreamReader(Patient_path + this.username + ".txt");
                    }
                    else
                    {
                        throw new CustomException("Unable to Open Patient File");
                    }

                    sw = new StreamWriter(Patient_path + "temp.txt");
                }
                catch (CustomException msg)
                {
                    MessageBox.Show(msg.Message);
                    return 0;
                }
            }

            for (int i = 0; i < limit ; ++i)
            {
                line = sr.ReadLine(); //writing as it is upto email
                sw.WriteLine(line);
            }

            line = sr.ReadLine();
            sw.WriteLine(email); //Wrinting editing email in the file

            while ((line = sr.ReadLine()) != null)
            {
                sw.WriteLine(line);
            }

            sr.Close();
            sw.Close();

            if (First_Page.opt1 == 0)
            {
                File.Delete(Doctor_path + username + ".txt");
                File.Move(Doctor_path + "temp.txt", Doctor_path + username + ".txt");
            }
            else
            {
                File.Delete(Patient_path + username + ".txt");
                File.Move(Patient_path + "temp.txt", Patient_path + username + ".txt");
            }
            return 1;
        }

        public string get_email()
        {
            return this.email;
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            if(randomNumber == txtPin.Text)
            {
                email = txtEmail.Text;
                editEmail(email);
                MessageBox.Show("Email Successfully Edited!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                this.Close();
            }
            else
            {
                email = null;
                lblPin.Text = "Wrong Pin";
            }
        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!isTextBoxEmpty(txtPin.Text))
                {
                    try
                    {
                        if (randomNumber == txtPin.Text)
                        {
                            labelPin.Text = "";
                            timer1.Stop();
                            int success = editEmail(email);

                            try
                            {
                                if (success == 1)
                                {
                                    MessageBox.Show("Email Successfully Edited!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    throw new CustomException("An Error Occurred during password editing");
                                }
                            }
                            catch (CustomException msg)
                            {
                                MessageBox.Show(msg.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            finally
                            {
                                this.Hide();
                                this.Close();
                            }
                        }
                        else
                        {
                            throw new CustomException("Wrong Pin Code");
                        }
                    }
                    catch (CustomException msg)
                    {
                        labelPin.Text = msg.Message;
                    }
                }
                else
                {
                    throw new CustomException("Please Enter Pin Code");
                }
            }
            catch (CustomException msg)
            {
                labelPin.Text = msg.Message;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            email = null;
            this.Hide();
            this.Close();
        }


    }
}
