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
    public partial class ChangePassword : Form
    {
        string username;
        string email;
        string oldpass;
        string finalString;
        string randomNumber;

        bool current = false;
        bool neww = false;
        bool retype = false;

        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(string email, string oldpass, string username)
        {
            this.username = username;
            this.email = email;
            this.oldpass = oldpass;
            InitializeComponent();
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

        private void Change_Password__Edit_info__Load(object sender, EventArgs e)
        {
            lblTimer.Visible = false;
            txtPin.Enabled = false;
            btnSubmit.Enabled = false;
            btnSubmit.BackColor = Color.Silver;
            loadCaptchaImage();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadCaptchaImage();
        }

        private void txtCurrent_Leave(object sender, EventArgs e)
        {
            if(oldpass != txtCurrent.Text)
            {
                lblCurrent.Text = "Password is Incorrect";
            }
            else
            {
                lblCurrent.Text = "";
                btnSubmit.Enabled = true;
                btnSubmit.BackColor = Color.Black;
            }
        }

        private void lblNew_Leave(object sender, EventArgs e)
        {
            Patient p = new Patient();
            if(!p.isValidPassword(txtNew.Text))
            {
                lblNew.Text = "Atleast 8 characters";
            }
            else
            {
                lblNew.Text = "";
            }
        }
       

        private void txtRetype_Leave(object sender, EventArgs e)
        {
            if (txtNew.Text != txtRetype.Text)
            {
                lblRetype.Text = "Password Donot Match";
            }
            else
            {
                lblRetype.Text = "";
            }
        }

        bool validateTextBoxes()
        {
            Patient p = new Patient();
            int flag = 0;

                if (oldpass != txtCurrent.Text)
                {
                    lblCurrent.Text = "Password is Incorrect";
                    flag = 1;
                }

                if (!p.isValidPassword(txtNew.Text))
                {
                    lblNew.Text = "Password Donot Match";
                    flag = 1;
                }

                if (txtNew.Text != txtRetype.Text)
                {
                    lblRetype.Text = "Password Donot Match";
                    flag = 1;
                }

                if (txtCaptcha.Text != finalString)
                {
                    lblCaptcha.Text = "Text Donot Match Image";
                    flag = 1;
                }
    
                if (flag == 0)
                    return true;
                else
                    return false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblCaptcha.Text = "";

            if (validateTextBoxes())
            {
                Random rnd = new Random();
                randomNumber = (rnd.Next(1000, 9999)).ToString();

                EmailProgressing check = new EmailProgressing(email, randomNumber);
                check.ShowDialog();

                timer1.Start();

                btnSubmit.Enabled = false;
                btnSubmit.BackColor = Color.Silver;

                txtPin.Enabled = true;
                txtNew.Enabled = false;
                txtRetype.Enabled = false;
                txtCurrent.Enabled = false;
                txtCaptcha.Enabled = false;
            }
        }

        int count = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Visible = true;
            lblTimer.Text = "00 : " + count.ToString();

            if (count == 0)
            {
                lblPin.Text = "";
                lblTimer.Text = "";
                timer1.Stop();


                this.Close();
                this.Hide();
                ChangePassword change = new ChangePassword(email, oldpass, username);
                change.ShowDialog();

            }
            count -= 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        int editPassword(string password)
        {
            string line;

            string Doctor_path = First_Page.doc_path;
            string Patient_path = First_Page.pat_path;

            StreamWriter sw = null;
            StreamReader sr = null;

            if (First_Page.opt1 == 0)
            {
                try
                {
                    if (File.Exists(Doctor_path + username + ".txt"))
                    {
                        sr = new StreamReader(Doctor_path + username + ".txt");
                    }
                    else
                    {
                        throw new CustomException("Unable to Open File");
                    }
                    sw = new StreamWriter(Doctor_path + "temp.txt");
                }
                catch(CustomException msg)
                {
                    MessageBox.Show(msg.Message);
                    return 0;
                }
            }
            else
            {
                try
                {
                    if (File.Exists(Patient_path + username + ".txt"))
                    {
                        sr = new StreamReader(Patient_path + username + ".txt");
                    }
                    else
                    {
                        throw new CustomException("Unable to Open File");
                    }

                    sw = new StreamWriter(Patient_path + "temp.txt");
                }
                catch(CustomException msg)
                {
                    MessageBox.Show(msg.Message);
                    return 0;
                }
            }

            for (int i = 0; i < 3; ++i)
            {
                line = sr.ReadLine(); //writing as it is upto username
                sw.WriteLine(line);
            }

            line = sr.ReadLine();
            sw.WriteLine(txtNew.Text); //editing password in the file

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

        bool isTextBoxEmpty(string text)
        {
            return (string.IsNullOrEmpty(text));
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
                            timer1.Stop();

                            lblPin.Text = "";
                            int success = editPassword(txtNew.Text);

                            try
                            {
                                if (success == 1)
                                {
                                    MessageBox.Show("Password Successfully Edited!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        lblPin.Text = msg.Message;
                    }
                }
                else
                {
                    throw new CustomException("Please Enter Pin Code");
                }
            }
            catch (CustomException msg)
            {
                lblPin.Text = msg.Message;
            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (current == true)
                current = false;
            else
                current = true;
            if (current)
            {
                txtCurrent.UseSystemPasswordChar = false;
            }
            else
            {
                txtCurrent.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (neww == true)
                neww = false;
            else
                neww = true;
            if (neww)
            {
                txtNew.UseSystemPasswordChar = false;
            }
            else
            {
                txtNew.UseSystemPasswordChar = true;
            }
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (retype == true)
                retype = false;
            else
                retype = true;
            if (retype)
            {
                txtRetype.UseSystemPasswordChar = false;
            }
            else
            {
                txtRetype.UseSystemPasswordChar = true;
            }
        }
    }
}
