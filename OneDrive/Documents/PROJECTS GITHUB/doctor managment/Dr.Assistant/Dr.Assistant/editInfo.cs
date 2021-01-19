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
    public partial class editInfo : Form
    {
        string Patient_path;
        string Doctor_path;

        private string username;
        //private static string fname = null;
        private Patient p = new Patient();

        private doctor d;

        string speciality;

        public editInfo()
        {
            InitializeComponent();
        }

        public editInfo(string username)
        {
            this.username = username;
            Doctor_path = First_Page.doc_path;
            Patient_path = First_Page.pat_path;
            InitializeComponent();
        }

        void checkSpeciality()
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(Doctor_path + username + ".txt");
            }
            catch { MessageBox.Show("Unable to Open File"); }

            string trash;

            for (int i = 0; i < 6; ++i)
            {
                trash = sr.ReadLine();
            }

            speciality = sr.ReadLine();

            sr.Close();
        }

        private void DoctorInfo()
        {
            checkSpeciality();
            if (speciality == "General Physician") { d = new generalphysician(); }
            else if (speciality == "Otolaryngologist") { d = new otolaryngologist(); }
            else if (speciality == "Cardiologist") { d = new cardiologist(); }
            else if (speciality == "Pulmonologist") { d = new pulmonologist(); }
            else if (speciality == "Infectologist") { d = new infectologist(); }

            StreamReader sr = null;

            try
            {
                if (File.Exists(Doctor_path + username + ".txt"))
                    sr = new StreamReader(Doctor_path + username + ".txt");
                else
                    throw new CustomException("Cannot Open Doctor username.txt");


                txtFname.Text = sr.ReadLine();
                d._FirstName = txtFname.Text;

                txtLname.Text = sr.ReadLine();
                d._LastName = txtLname.Text;

                txtUsername.Text = sr.ReadLine();

                txtPassword.Text = sr.ReadLine();
                d._Password = txtPassword.Text;

                txtAge.Text = sr.ReadLine();
                d._Age = Int32.Parse(txtAge.Text);

                txtGen.Text = sr.ReadLine();

                txtSpeciality.Text = sr.ReadLine();

                txtPhone.Text = sr.ReadLine();
                d._PhoneNo = txtPhone.Text;

                txtAddress.Text = sr.ReadLine();
                d._Address = txtAddress.Text;

                txtPostal.Text = sr.ReadLine();
                d._PostalCode = txtPostal.Text;

                txtFees.Text = sr.ReadLine();
                d._Fee = Int32.Parse(txtFees.Text);

                txtDescription.Text = sr.ReadLine();
                d._description = txtDescription.Text;

                txtEmail.Text = sr.ReadLine();
                d._EmailAddress = txtEmail.Text;

                sr.Close();

            }
            catch(CustomException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void PatientInfo()
        {
            StreamReader sr = null;
            try
            {
                if (File.Exists(Patient_path + username + ".txt"))
                {
                    sr = new StreamReader(Patient_path + username + ".txt");
                }
                else
                    throw new CustomException("Patient usernames.txt");

                txtFname.Text = sr.ReadLine();
                p._FirstName = txtFname.Text; //saving in obj so that it can be used later in program

                txtLname.Text = sr.ReadLine();
                p._LastName = txtLname.Text;

                txtUsername.Text = sr.ReadLine();

                txtPassword.Text = sr.ReadLine();
                p._Password = txtPassword.Text;

                txtAge.Text = sr.ReadLine();
                p._Age = Int32.Parse(txtAge.Text);

                txtGen.Text = sr.ReadLine();

                txtPhone.Text = sr.ReadLine();
                p._PhoneNo = txtPhone.Text;

                txtAddress.Text = sr.ReadLine();
                p._Address = txtAddress.Text;

                txtPostal.Text = sr.ReadLine();
                p._PostalCode = txtPostal.Text;

                txtEmail.Text = sr.ReadLine();
                p._EmailAddress = txtEmail.Text;

                sr.Close();
            }
            catch(CustomException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void editInfo_Load(object sender, EventArgs e)
        {

            if (First_Page.opt1 == 1)
            {
                pictureBox1.Visible = false;
                txtDescription.Visible = false;
                lblDescription.Visible = false;
                editDes.Visible = false;
                applyDes.Visible = false;
                lblF.Visible = false;
                lblS.Visible = false;
                txtSpeciality.Visible = false;
                txtFees.Visible = false;

                PatientInfo();  //display info
            }
            else
            {
                pictureBox2.Visible = false;
                DoctorInfo();   //display info
            }

            txtFname.Enabled = false;
            txtLname.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            txtAge.Enabled = false;
            txtAddress.Enabled = false;
            txtPhone.Enabled = false;
            txtPostal.Enabled = false;
            txtFees.Enabled = false;
            txtSpeciality.Enabled = false;
            txtGen.Enabled = false;
            txtEmail.Enabled = false;

            applyFname.Visible = false;
            applyLname.Visible = false;
            applyAge.Visible = false;
            applyPhone.Visible = false;
            applyPostal.Visible = false;
            applyAddress.Visible = false;
            applyDes.Visible = false;
        }

        //First Name
        private void editFname_Click(object sender, EventArgs e)
        {
            txtFname.Enabled = true;
            txtFname.Clear();
            txtFname.Focus();
            editFname.Enabled = false;
            editFname.BackColor = Color.Silver;
            applyFname.Visible = true;
        }

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch;
            ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void applyFname_Click(object sender, EventArgs e) //editing first name
        {
            string fname = null, line = null;

            StreamWriter sw = null;
            StreamReader sr = null;

            if (string.IsNullOrEmpty(txtFname.Text) && First_Page.opt1 == 1)
            {
                MessageBox.Show("Previous First Name Retained");
                txtFname.Text = p._FirstName;
            }

            else if (string.IsNullOrEmpty(txtFname.Text) && First_Page.opt1 == 0)
            {
                MessageBox.Show("Previous First Name Retained");
                txtFname.Text = d._FirstName;
            }

            else if (p.isValidFirstName(txtFname.Text))
            {
                fname = txtFname.Text;

                if (First_Page.opt1 == 0)
                {
                    try
                    {
                        sw = new StreamWriter(Doctor_path + "temp.txt");
                        if (File.Exists(Doctor_path + username + ".txt"))
                            sr = new StreamReader(Doctor_path + username + ".txt");
                        else
                            throw new CustomException("Cannot open Dr.usernames.txt");

                    }
                    catch(CustomException em) 
                    {
                        MessageBox.Show(em.Message);
                    }
                }
                else
                {

                    sw = new StreamWriter(Patient_path + "temp.txt");
                    try
                    {
                        if (File.Exists(Patient_path + username + ".txt"))
                            sr = new StreamReader(Patient_path + username + ".txt");
                        else
                            throw new CustomException("cannot Patient usernames.txt");
                    }
                    catch(CustomException en) 
                    {
                        MessageBox.Show(en.Message);
                    }
                }

                line = sr.ReadLine();
                sw.WriteLine(fname);

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

                MessageBox.Show("First Name Successfully Edited!!");
            }

            applyFname.Visible = false;
            editFname.Enabled = true;
            editFname.BackColor = Color.Black;
            txtFname.Enabled = false;

        }//applyfname bracket

        //Last Name
        private void editLname_Click(object sender, EventArgs e)
        {
            txtLname.Enabled = true;
            txtLname.Clear();
            txtLname.Focus();
            editLname.Enabled = false;
            editLname.BackColor = Color.Silver;
            applyLname.Visible = true;
        }

        private void txtLname_KeyPress(object sender, KeyPressEventArgs e) //validating only characters can be enter
        {
            char ch;
            ch = e.KeyChar;
            if (char.IsLetter(ch) || ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void applyLname_Click(object sender, EventArgs e)
        {
            txtLname.Enabled = true;
            txtLname.Focus();

            string lname = null, line = null;

            if (string.IsNullOrEmpty(txtLname.Text) && First_Page.opt1 == 1)
            {
                MessageBox.Show("Previous Last Name Retained");
                txtLname.Text = p._LastName;
            }

            else if (string.IsNullOrEmpty(txtLname.Text) && First_Page.opt1 == 0)
            {
                MessageBox.Show("Previous Last Name Retained");
                txtLname.Text = d._LastName;
            }

            else if (p.isValidLastName(txtLname.Text))
            {
                lname = txtLname.Text;

                StreamWriter sw = null;
                StreamReader sr = null;

                if (First_Page.opt1 == 0)
                {
                    try
                    {
                        sw = new StreamWriter(Doctor_path + "temp.txt");
                        if (File.Exists(Doctor_path + username + ".txt"))
                            sr = new StreamReader(Doctor_path + username + ".txt");
                        else
                            throw new CustomException("Cannot open Dr.usernames.txt");

                    }
                    catch (CustomException em)
                    {
                        MessageBox.Show(em.Message);
                    }
                }
                else
                {

                    sw = new StreamWriter(Patient_path + "temp.txt");
                    try
                    {
                        if (File.Exists(Patient_path + username + ".txt"))
                            sr = new StreamReader(Patient_path + username + ".txt");
                        else
                            throw new CustomException("cannot Patient usernames.txt");
                    }
                    catch (CustomException en)
                    {
                        MessageBox.Show(en.Message);
                    }
                }

                for (int i = 0; i < 1; ++i)
                {
                    line = sr.ReadLine(); //writing first name as it is
                    sw.WriteLine(line);
                }
                line = sr.ReadLine();
                sw.WriteLine(lname); //Wrinting editing last name in the file

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
                MessageBox.Show("Last Name Successfully Edited!!");
            }
            applyLname.Visible = false;
            editLname.Enabled = true;
            editLname.BackColor = Color.Black;
            txtLname.Enabled = false;

        }//applyLname bracket

        //Age
        private void editAge_Click(object sender, EventArgs e)
        {
            txtAge.Enabled = true;
            txtAge.Clear();
            txtAge.Focus();
            editAge.Enabled = false;
            editAge.BackColor = Color.Silver;
            applyAge.Visible = true;
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch;
            ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void applyAge_Click(object sender, EventArgs e)
        {
            txtAge.Enabled = true;
            txtAge.Focus();

            int age;
            string line = null;
            //validation

            if (string.IsNullOrEmpty(txtAge.Text) && First_Page.opt1 == 1)
            {
                MessageBox.Show("Previous Age Retained");
                txtAge.Text = p._Age.ToString();
            }

            else if (string.IsNullOrEmpty(txtAge.Text) && First_Page.opt1 == 0)
            {
                MessageBox.Show("Previous Age Retained");
                txtAge.Text = d._Age.ToString();
            }

            else if (p.isValidAge(Int32.Parse(txtAge.Text)))
            {
                age = Int32.Parse(txtAge.Text);

                StreamWriter sw = null;
                StreamReader sr = null;

                if (First_Page.opt1 == 0)
                {
                    try
                    {
                        sw = new StreamWriter(Doctor_path + "temp.txt");
                        if (File.Exists(Doctor_path + username + ".txt"))
                            sr = new StreamReader(Doctor_path + username + ".txt");
                        else
                            throw new CustomException("Cannot open Dr.usernames.txt");

                    }
                    catch (CustomException em)
                    {
                        MessageBox.Show(em.Message);
                    }
                }
                else
                {

                    sw = new StreamWriter(Patient_path + "temp.txt");
                    try
                    {
                        if (File.Exists(Patient_path + username + ".txt"))
                            sr = new StreamReader(Patient_path + username + ".txt");
                        else
                            throw new CustomException("cannot Patient usernames.txt");
                    }
                    catch (CustomException en)
                    {
                        MessageBox.Show(en.Message);
                    }
                }

                for (int i = 0; i < 4; ++i)
                {
                    line = sr.ReadLine(); //writing first name as it is
                    sw.WriteLine(line);
                }

                line = sr.ReadLine();
                sw.WriteLine(age); //Wrinting editing last name in the file

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
                MessageBox.Show("Age Successfully Edited!!");
            }
            else
            {
                if (First_Page.opt1 == 0)
                {
                    MessageBox.Show("Age Must Greater than zero!!!Previous Age Retained");
                    txtAge.Text = d._Age.ToString();
                }
                else
                {
                    MessageBox.Show("Age Must Greater than zero!!!Previous Age Retained");
                    txtAge.Text = p._Age.ToString();
                }
            }
            applyAge.Visible = false;
            editAge.Enabled = true;
            editAge.BackColor = Color.Black;
            txtAge.Enabled = false;
        } //apply Age bracket

        //Phone No
        private void editPhone_Click(object sender, EventArgs e)
        {
            txtPhone.Enabled = true;
            txtPhone.Clear();
            txtPhone.Focus();
            editPhone.Enabled = false;
            editPhone.BackColor = Color.Silver;
            applyPhone.Visible = true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch;
            ch = e.KeyChar;
            if (char.IsDigit(ch) || ch == 8 || ch == 45)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void applyPhone_Click(object sender, EventArgs e)
        {
            txtPhone.Enabled = false;
            txtPhone.Focus();
            int index;
            string phoneNo;
            string line = null;
            //validation required

            if ((string.IsNullOrEmpty(txtPhone.Text) || (!p.isValidPhoneNo(txtPhone.Text)) ) && First_Page.opt1 == 1)
            {
                MessageBox.Show("Previous Phone No Retained");
                txtPhone.Text = p._PhoneNo;
            }

            else if ((string.IsNullOrEmpty(txtPhone.Text) || (!p.isValidPhoneNo(txtPhone.Text))) && First_Page.opt1 == 0)
            {
                MessageBox.Show("Previous Phone No Retained");
                txtPhone.Text = d._PhoneNo;
            }

            else
            {
                phoneNo = txtPhone.Text;

                StreamWriter sw = null;
                StreamReader sr = null;

                if (First_Page.opt1 == 0)
                {
                    try
                    {
                        sw = new StreamWriter(Doctor_path + "temp.txt");
                        if (File.Exists(Doctor_path + username + ".txt"))
                            sr = new StreamReader(Doctor_path + username + ".txt");
                        else
                            throw new CustomException("Cannot open Dr.usernames.txt");

                    }
                    catch (CustomException em)
                    {
                        MessageBox.Show(em.Message);
                    }
                }
                else
                {

                    sw = new StreamWriter(Patient_path + "temp.txt");
                    try
                    {
                        if (File.Exists(Patient_path + username + ".txt"))
                            sr = new StreamReader(Patient_path + username + ".txt");
                        else
                            throw new CustomException("cannot Patient usernames.txt");
                    }
                    catch (CustomException en)
                    {
                        MessageBox.Show(en.Message);
                    }
                }

                if (First_Page.opt1 == 0) // because patient dont have speciality attribute
                {
                    index = 7;
                }
                else
                {
                    index = 6;
                }

                for (int i = 0; i < index; ++i)
                {
                    line = sr.ReadLine(); //writing first name as it is
                    sw.WriteLine(line);
                }
                line = sr.ReadLine();
                sw.WriteLine(phoneNo); //Wrinting editing last name in the file

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
                MessageBox.Show("Phone# Successfully Edited!!");
            }
            applyPhone.Visible = false;
            editPhone.Enabled = true;
            editPhone.BackColor = Color.Black;
            txtPhone.Enabled = false;
        }//Phone no bracket

        //Address
        private void editArea_Click(object sender, EventArgs e)
        {
            txtAddress.Enabled = true;
            txtAddress.Clear();
            txtAddress.Focus();
            editAddress.Enabled = false;
            editAddress.BackColor = Color.Silver;
            applyAddress.Visible = true;
        }
        private void applyAddress_Click(object sender, EventArgs e)
        {
            txtAddress.Enabled = false;
            txtAddress.Focus();

            string address;
            string line = null;

            //validation required

            if (string.IsNullOrEmpty(txtAddress.Text) && First_Page.opt1 == 1)
            {
                MessageBox.Show("Previous Address Retained");
                txtAddress.Text = p._Address;
            }

            else if (string.IsNullOrEmpty(txtAddress.Text) && First_Page.opt1 == 0)
            {
                MessageBox.Show("Previous Address Retained");
                txtAddress.Text = d._Address;
            }

            else
            {
                address = txtAddress.Text;

                StreamWriter sw = null;
                StreamReader sr = null;

                if (First_Page.opt1 == 0)
                {
                    try
                    {
                        sw = new StreamWriter(Doctor_path + "temp.txt");
                        if (File.Exists(Doctor_path + username + ".txt"))
                            sr = new StreamReader(Doctor_path + username + ".txt");
                        else
                            throw new CustomException("Cannot open Dr.usernames.txt");

                    }
                    catch (CustomException em)
                    {
                        MessageBox.Show(em.Message);
                    }
                }
                else
                {

                    sw = new StreamWriter(Patient_path + "temp.txt");
                    try
                    {
                        if (File.Exists(Patient_path + username + ".txt"))
                            sr = new StreamReader(Patient_path + username + ".txt");
                        else
                            throw new CustomException("cannot Patient usernames.txt");
                    }
                    catch (CustomException en)
                    {
                        MessageBox.Show(en.Message);
                    }
                }

                for (int i = 0; i < 8; ++i)
                {
                    line = sr.ReadLine(); //writing first name as it is
                    sw.WriteLine(line);
                }

                line = sr.ReadLine();
                sw.WriteLine(address); //Wrinting editing last name in the file

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
                MessageBox.Show("Address Successfully Edited!!");
            }
            applyAddress.Visible = false;
            editAddress.Enabled = true;
            editAddress.BackColor = Color.Black;
            txtAddress.Enabled = false;

        }//Address bracket

        //Postal Code
        private void EditPostal_Click(object sender, EventArgs e)
        {
            txtPostal.Enabled = true;
            txtPostal.Clear();
            txtPostal.Focus();
            editPostal.Enabled = false;
            editPostal.BackColor = Color.Silver;
            applyPostal.Visible = true;
        }

        private void txtPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch;
            ch = e.KeyChar;
            if (char.IsDigit(ch) || ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void editDes_Click(object sender, EventArgs e)
        {
            txtDescription.Enabled = true;
            txtDescription.Clear();
            txtDescription.Focus();
            editDes.Enabled = false;
            editDes.BackColor = Color.Silver;
            applyDes.Visible = true;
        }

        private void applyPostal_Click(object sender, EventArgs e)
        {
            txtPostal.Enabled = false;
            txtPostal.Focus();

            string code;
            string line = null;
            //validation required

            if (string.IsNullOrEmpty(txtPostal.Text) && First_Page.opt1 == 1)
            {
                MessageBox.Show("Previous Postal Code Retained");
                txtPostal.Text = p._PostalCode;
            }

            else if (string.IsNullOrEmpty(txtPostal.Text) && First_Page.opt1 == 0)
            {
                MessageBox.Show("Previous Postal Code Retained");
                txtPostal.Text = d._PostalCode;
            }

            else if (p.isValidPostalCode(txtPostal.Text))
            {
                code = txtPostal.Text;

                StreamWriter sw = null;
                StreamReader sr = null;

                if (First_Page.opt1 == 0)
                {
                    try
                    {
                        sw = new StreamWriter(Doctor_path + "temp.txt");
                        if (File.Exists(Doctor_path + username + ".txt"))
                            sr = new StreamReader(Doctor_path + username + ".txt");
                        else
                            throw new CustomException("Cannot open Dr.usernames.txt");

                    }
                    catch (CustomException em)
                    {
                        MessageBox.Show(em.Message);
                    }
                }
                else
                {

                    sw = new StreamWriter(Patient_path + "temp.txt");
                    try
                    {
                        if (File.Exists(Patient_path + username + ".txt"))
                            sr = new StreamReader(Patient_path + username + ".txt");
                        else
                            throw new CustomException("cannot Patient usernames.txt");
                    }
                    catch (CustomException en)
                    {
                        MessageBox.Show(en.Message);
                    }
                }

                for (int i = 0; i < 9; ++i)
                {
                    line = sr.ReadLine(); //writing first name as it is
                    sw.WriteLine(line);
                }

                line = sr.ReadLine();
                sw.WriteLine(code); //Wrinting editing last name in the file

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
                MessageBox.Show("Last Name Successfully Edited!!");
            }
            applyPostal.Visible = false;
            editPostal.Enabled = true;
            editPostal.BackColor = Color.Black;
            txtPostal.Enabled = false;
        }//apply postal code

        private void applyDes_Click(object sender, EventArgs e)
        {
            string description = null, line = null;

            StreamWriter sw = null;
            StreamReader sr = null;

            if (string.IsNullOrEmpty(txtDescription.Text) && First_Page.opt1 == 0)
            {
                MessageBox.Show("Previous Description Retained");
                txtDescription.Text = d._description;
            }

            else
            {
                description = txtDescription.Text;

                try
                {
                    sw = new StreamWriter(Doctor_path + "temp.txt");
                    if (File.Exists(Doctor_path + username + ".txt"))
                        sr = new StreamReader(Doctor_path + username + ".txt");
                    else
                        throw new CustomException("Cannot open Dr.usernames.txt");

                }
                catch (CustomException em)
                {
                    MessageBox.Show(em.Message);
                }

                for (int i = 0; i < 11; ++i)
                {
                    line = sr.ReadLine(); //writing first name as it is
                    sw.WriteLine(line);
                }

                line = sr.ReadLine();
                sw.WriteLine(description);

                while ((line = sr.ReadLine()) != null)
                {
                    sw.WriteLine(line);
                }
                sr.Close();
                sw.Close();

                File.Delete(Doctor_path + username + ".txt");
                File.Move(Doctor_path + "temp.txt", Doctor_path + username + ".txt");

                MessageBox.Show("Description Successfully Edited!!");
            }

            applyDes.Visible = false;
            editDes.Enabled = true;
            editDes.BackColor = Color.Black;
            txtDescription.Enabled = false;

        }

        private void editEmail_Click(object sender, EventArgs e)
        {
            ChangeEmail change = new ChangeEmail(this.username);
            change.ShowDialog();

            if (change.get_email() != null)
            {
                txtEmail.Text = change.get_email();

                if (First_Page.opt1 == 0)
                    d._EmailAddress = txtEmail.Text;
                else
                    p._EmailAddress = txtEmail.Text;
            }
        }

        private void editPassword_Click(object sender, EventArgs e)
        {
            if (First_Page.opt1 == 0)
            {
                ChangePassword change = new ChangePassword(d._EmailAddress, d._Password, this.username);
                change.ShowDialog();
            }
            else
            {
                ChangePassword change = new ChangePassword(p._EmailAddress, p._Password, this.username);
                change.ShowDialog();
            }
        }

        //back button
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure, You Want to Exit", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Exit
        private void button10_Click(object sender, EventArgs e)
        {
            if (First_Page.opt1 == 0)
            {
                this.Hide();
                viewInfo view = new viewInfo(this.username);
                view.ShowDialog();
                this.Close();
            }

            if (First_Page.opt1 == 1)
            {
                this.Hide();
                patientFunctions pf = new patientFunctions(this.username);
                pf.ShowDialog();
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}




