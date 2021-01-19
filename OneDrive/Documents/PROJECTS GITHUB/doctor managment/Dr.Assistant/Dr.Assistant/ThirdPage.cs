using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace OOP_PROJECT_WINDOW_FORM
{
    public partial class SignUp : Form
    {

        Patient p = new Patient();
        doctor d1 = new generalphysician();

        public SignUp()
        {
            InitializeComponent();
        }


        private void SignUp_Load(object sender, EventArgs e)
        {
            if (First_Page.opt1 == 1) //checking wheather it is a doctor or patient  (patient-> opt1== 1, docto-> opt1==0)
            {
                SpecialityCb.Enabled = false;
                DescriptionTb.Enabled = false;
            }
        }

        bool checkTextBoxes() //for validation of text boxes
        {
            int flag = 0;
            if (string.IsNullOrEmpty(FirstNameTb.Text)) { errorProvider1.SetError(FirstNameTb, "Please Enter Your First Name!"); flag = 1; }

            if (string.IsNullOrEmpty(LastNameTb.Text)) { errorProvider1.SetError(LastNameTb, "Please Enter Your Last Name !"); flag = 1; }

            if (string.IsNullOrEmpty(UserNameTb.Text)) { errorProvider1.SetError(UserNameTb, "Please Enter Your Username !"); flag = 1; }

            if (string.IsNullOrEmpty(PasswordTb.Text)) { errorProvider1.SetError(PasswordTb, "Please Enter Password !"); flag = 1; ; }

            if (string.IsNullOrEmpty(AgeTb.Text)) { errorProvider1.SetError(AgeTb, "Please Enter Your Age !"); flag = 1; }

            if (string.IsNullOrEmpty(GenderCb.Text)) { errorProvider1.SetError(GenderCb, "Please Select Gender !"); flag = 1; }

            if (string.IsNullOrEmpty(PhoneNoTb.Text)) { errorProvider1.SetError(PhoneNoTb, "Please Enter Your PhoneNo !"); flag = 1; }

            if (string.IsNullOrEmpty(PostalCodeTb.Text)) { errorProvider1.SetError(PostalCodeTb, "Please Enter Your First !"); flag = 1; }

            if (First_Page.opt1 == 0)//only for doctors
            {
                if (string.IsNullOrEmpty(SpecialityCb.Text)) { errorProvider1.SetError(SpecialityCb, "Please Select Your Speciality !"); flag = 1; }
            }

            if (flag == 0)
                return true;
            else
                return false;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Console.Beep();

            string msg;

            if(First_Page.opt1 == 0) { msg = "Username and Speciality won't change, Do You Want to SignUp"; }
            else { msg = "Username won't change, Do You Want to SignUp"; }

            if (checkTextBoxes())
            {
                if (MessageBox.Show(msg , "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (First_Page.opt1 == 0)
                    {
                        doctor doc = null;
                        if (SpecialityCb.SelectedIndex == 0) { doc = new generalphysician(); }
                        else if (SpecialityCb.SelectedIndex == 1) { doc = new otolaryngologist(); }
                        else if (SpecialityCb.SelectedIndex == 2) { doc = new cardiologist(); }
                        else if (SpecialityCb.SelectedIndex == 3) { doc = new pulmonologist(); }
                        else { doc = new infectologist(); }

                        doc._FirstName = FirstNameTb.Text;
                        doc._LastName = LastNameTb.Text;
                        doc._Username = UserNameTb.Text;
                        doc._Password = PasswordTb.Text;
                        doc._Age = Int32.Parse(AgeTb.Text);
                        doc._PhoneNo = PhoneNoTb.Text;
                        doc._PostalCode = PostalCodeTb.Text;
                        doc._Speciality = SpecialityCb.Text;
                        doc._Address = AddressTb.Text;
                        doc._Gender = GenderCb.Text;
                        doc._description = DescriptionTb.Text;

                        this.Hide();
                        btnResend email = new btnResend(doc);
                        email.ShowDialog();
                        this.Close();
                    }

                    else
                    { 
                        p._FirstName = FirstNameTb.Text;
                        p._LastName = LastNameTb.Text;
                        p._Username = UserNameTb.Text;
                        p._Password = PasswordTb.Text;
                        p._Age = Int32.Parse(AgeTb.Text);
                        p._PhoneNo = PhoneNoTb.Text;
                        p._PostalCode = PostalCodeTb.Text;
                        p._Address = AddressTb.Text;
                        p._Gender = GenderCb.Text;

                        this.Hide();
                        btnResend email = new btnResend(p);
                        email.ShowDialog();
                        this.Close();
                    }

                }
            }//validation if

        }//function bracket

        //FirstName
        private void FirstNameTb_KeyPress(object sender, KeyPressEventArgs e) //only alphabets and backspace can be entered 
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

        private void FirstNameTb_Leave(object sender, EventArgs e)
        {

            switch (First_Page.opt1)
            {
                case 0:
                    
                    if (string.IsNullOrEmpty(FirstNameTb.Text))
                    {
                        FirstNameTb.Focus();
                        errorProvider1.SetError(FirstNameTb, "Please Enter Your First !");
                    }
                    else if (!d1.isValidFirstName(FirstNameTb.Text))
                    {
                        FirstNameTb.Focus();
                        errorProvider1.SetError(FirstNameTb, "FirstName must not contain spaces , special characters and numbers !");
                    }
                    else if (d1.isValidFirstName(FirstNameTb.Text))
                    {
                        d1._FirstName = FirstNameTb.Text;
                        errorProvider1.Clear();
                    }
                    break;
                case 1:
                    if (string.IsNullOrEmpty(FirstNameTb.Text))
                    {
                        FirstNameTb.Focus();
                        errorProvider1.SetError(FirstNameTb, "Please Enter Your First !");
                    }
                    else if (!p.isValidFirstName(FirstNameTb.Text))
                    {
                        FirstNameTb.Focus();
                        errorProvider1.SetError(FirstNameTb, "FirstName must not contain spaces , special characters and numbers !");
                    }
                    else if (p.isValidFirstName(FirstNameTb.Text))
                    {
                        errorProvider1.Clear();
                    }
                    break;
            }
        }

        //LastName
        private void LastNameTb_KeyPress(object sender, KeyPressEventArgs e)//only alphabets and backspace can be entered 
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
        private void LastNameTb_Leave(object sender, EventArgs e)
        {
            switch (First_Page.opt1)
            {
                case 0:
                    if (string.IsNullOrEmpty(LastNameTb.Text))
                    {
                        LastNameTb.Focus();
                        errorProvider1.SetError(LastNameTb, "Please Enter Your LastName !");
                    }

                    else if (!d1.isValidLastName(LastNameTb.Text))
                    {
                        LastNameTb.Focus();
                        errorProvider1.SetError(LastNameTb, "LastName must not contain spaces , special characters or numbers !");
                    }


                    else if (d1.isValidLastName(LastNameTb.Text))
                    {
                        errorProvider1.Clear();
                    }

                    break;

                case 1:
                    if (string.IsNullOrEmpty(LastNameTb.Text))
                    {
                        LastNameTb.Focus();
                        errorProvider1.SetError(LastNameTb, "Please Enter Your LastName !");
                    }

                    else if (!p.isValidLastName(LastNameTb.Text))
                    {
                        LastNameTb.Focus();
                        errorProvider1.SetError(LastNameTb, "LastName must not contain spaces , special characters or numbers !");
                    }

                    else if (p.isValidLastName(LastNameTb.Text))
                    {
                        errorProvider1.Clear();
                    }

                    break;
            }
        }

        //Age
        private void AgeTb_KeyPress(object sender, KeyPressEventArgs e) //only numbers and backspace can be entered
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
        private void AgeTb_Leave(object sender, EventArgs e)
        {

            switch (First_Page.opt1)
            {
                case 0:
                    if (string.IsNullOrEmpty(AgeTb.Text))
                    {
                        AgeTb.Focus();
                        errorProvider1.SetError(AgeTb, "Please Enter Your Age !");
                    }
                    else if (!d1.isValidAge(Int32.Parse(AgeTb.Text)))
                    {
                        AgeTb.Focus();
                        errorProvider1.SetError(AgeTb, "Age must not be less than zero (0) !");
                    }
                    else if (d1.isValidAge(Int32.Parse(AgeTb.Text)))
                    {
                        // Age = Int32.Parse(AgeTb.Text);
                        errorProvider1.Clear();
                    }
                    break;
                case 1:
                    if (string.IsNullOrEmpty(AgeTb.Text))
                    {
                        AgeTb.Focus();
                        errorProvider1.SetError(AgeTb, "Please Enter Your Age !");
                    }
                    else if (!p.isValidAge(Int32.Parse(AgeTb.Text)))
                    {
                        AgeTb.Focus();
                        errorProvider1.SetError(AgeTb, "Age must not be less than zero (0) !");
                    }
                    else if (p.isValidAge(Int32.Parse(AgeTb.Text)))
                    {
                        //Age = Int32.Parse(AgeTb.Text);
                        errorProvider1.Clear();
                    }

                    break;
            }

        }

        //Template Function
        bool isUsernameUnique<T>(T user, string username)//validating that username is unique
        {
            string applicationLocation = System.Reflection.Assembly.GetEntryAssembly().Location;
            string applicationDirectory = System.IO.Path.GetDirectoryName(applicationLocation);

            StreamReader sr = null;
            try
            {
                sr = new StreamReader(applicationDirectory + "\\" + user + "\\" + "usernames.txt");
            }
            catch { MessageBox.Show("Unable to Open Usernames.txt"); }

            string line;

            while ((line = sr.ReadLine()) != null)
            {
                if (line == username)
                {
                    sr.Close();
                    return false; //same username found
                }
            }
            sr.Close();
            return true; //unique username
        }


        private void UserNameTb_Leave(object sender, EventArgs e)
        {
            switch (First_Page.opt1)
            {
                case 0:
                    if (string.IsNullOrEmpty(UserNameTb.Text))
                    {
                        UserNameTb.Focus();
                        errorProvider1.SetError(UserNameTb, "Please Enter Your Username !");
                    }
                    else if (!isUsernameUnique<string>("doctor", UserNameTb.Text))
                    {
                        UserNameTb.Focus();
                        errorProvider1.SetError(UserNameTb, "This Username Already Exists!!!");
                    }
                    else if (!d1.isValidUsername(UserNameTb.Text))
                    {
                        UserNameTb.Focus();
                        errorProvider1.SetError(UserNameTb, "Username must not contain spaces !");
                    }
                    else if (d1.isValidUsername(UserNameTb.Text))
                    {
                        //UserName = UserNameTb.Text;
                        errorProvider1.Clear();
                    }

                    break;

                case 1:
                    if (string.IsNullOrEmpty(UserNameTb.Text))
                    {
                        UserNameTb.Focus();
                        errorProvider1.SetError(UserNameTb, "Please Enter Your Username !");
                    }
                    else if (!isUsernameUnique<string>("patient", UserNameTb.Text))
                    {
                        UserNameTb.Focus();
                        errorProvider1.SetError(UserNameTb, "This Username Already Exists!!!");
                    }
                    else if (!p.isValidUsername(UserNameTb.Text))
                    {
                        UserNameTb.Focus();
                        errorProvider1.SetError(UserNameTb, "Username must not contain spaces !");
                    }

                    else if (p.isValidUsername(UserNameTb.Text))
                    {
                        //UserName = UserNameTb.Text;
                        errorProvider1.Clear();
                    }
                    break;
            }
        }

        //Password
        private void PasswordTb_Leave(object sender, EventArgs e)
        {
            switch (First_Page.opt1)
            {
                case 0:
                    if (string.IsNullOrEmpty(PasswordTb.Text))
                    {
                        PasswordTb.Focus();
                        errorProvider1.SetError(PasswordTb, "Please Enter Your Password !");
                    }
                    else if(!d1.isValidPassword(PasswordTb.Text))
                    {
                        PasswordTb.Focus();
                        errorProvider1.SetError(PasswordTb, "Password Should be of atleast 8 Characters!");
                    }
                    else
                    {
                        errorProvider1.Clear();
                    }
                    break;

                case 1:
                    if (string.IsNullOrEmpty(PasswordTb.Text))
                    {
                        PasswordTb.Focus();
                        errorProvider1.SetError(PasswordTb, "Please Enter Your Password !");
                    }
                    else if (!p.isValidPassword(PasswordTb.Text))
                    {
                        PasswordTb.Focus();
                        errorProvider1.SetError(PasswordTb, "Password Should be of atleast 8 Characters!");
                    }
                    else
                    {
                        errorProvider1.Clear();
                    }
                    break;
            }
        }

        //Gender
        private void GenderCb_Leave(object sender, EventArgs e)
        {
            switch (First_Page.opt1)
            {
                case 0:
                    if (string.IsNullOrEmpty(GenderCb.Text))
                    {
                        GenderCb.Focus();
                        errorProvider1.SetError(GenderCb, "Please Select Your Gender !");
                    }
                    else
                    {
                        errorProvider1.Clear();
                    }
                    break;

                case 1:
                    if (string.IsNullOrEmpty(GenderCb.Text))
                    {
                        GenderCb.Focus();
                        errorProvider1.SetError(GenderCb, "Please Select Your Gender !");
                    }
                    else
                    {
                        errorProvider1.Clear();
                    }
                    break;
            }
        }

        //Speciality
        private void SpecialityCb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SpecialityCb.Text))
            {
                SpecialityCb.Focus();
                errorProvider1.SetError(SpecialityCb, "Please Select your speciality !");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        //Phone No
        private void PhoneNoTb_KeyPress(object sender, KeyPressEventArgs e) //can only enter number, backspace and - 
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

        private void PhoneNoTb_Leave(object sender, EventArgs e)
        {
            switch (First_Page.opt1)
            {
                case 0:
                    if (string.IsNullOrEmpty(PhoneNoTb.Text))
                    {
                        PhoneNoTb.Focus();
                        errorProvider1.SetError(PhoneNoTb, "Please Enter Your Phone number !");
                    }

                    else if (!d1.isValidPhoneNo(PhoneNoTb.Text))
                    {
                        PhoneNoTb.Focus();
                        errorProvider1.SetError(PhoneNoTb, "Eg : 03xx-xxxxxxx !");
                    }

                    else if (d1.isValidUsername(PhoneNoTb.Text))
                    {
                        errorProvider1.Clear();
                    }

                    break;

                case 1:
                    if (string.IsNullOrEmpty(PhoneNoTb.Text))
                    {
                        PhoneNoTb.Focus();
                        errorProvider1.SetError(PhoneNoTb, "Please Enter Your Phone number !");
                    }

                    else if (!p.isValidPhoneNo(PhoneNoTb.Text))
                    {
                        PhoneNoTb.Focus();
                        errorProvider1.SetError(PhoneNoTb, "Eg : 03xx-xxxxxxx !");
                    }

                    else if (p.isValidUsername(PhoneNoTb.Text))
                    {
                        errorProvider1.Clear();
                    }

                    break;
            }
        }

        //Address
        private void AddressTb_Leave(object sender, EventArgs e)
        {
            switch (First_Page.opt1)
            {
                case 0:
                    if (string.IsNullOrEmpty(AddressTb.Text))
                    {
                        AddressTb.Focus();
                        errorProvider1.SetError(AddressTb, "Please Enter Your Address !");
                    }
                    else
                    {
                        errorProvider1.Clear();
                    }
                    break;

                case 1:
                    if (string.IsNullOrEmpty(AddressTb.Text))
                    {
                        AddressTb.Focus();
                        errorProvider1.SetError(AddressTb, "Please Enter Your Address !");
                    }
                    else
                    {
                        errorProvider1.Clear();
                    }
                    break;
            }
        }

        //postal code
        private void PostalCodeTb_KeyPress(object sender, KeyPressEventArgs e) //can only enter numbers and backspace
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

        private void PostalCodeTb_Leave(object sender, EventArgs e)
        {
            switch (First_Page.opt1)
            {
                case 0:
                    if (string.IsNullOrEmpty(PostalCodeTb.Text))
                    {
                        PostalCodeTb.Focus();
                        errorProvider1.SetError(PostalCodeTb, "Please Enter Your Postal Code !");
                    }
                    else if (!d1.isValidPostalCode(PostalCodeTb.Text))
                    {
                        PostalCodeTb.Focus();
                        errorProvider1.SetError(PostalCodeTb, "Postal Code must be in numbers !");
                    }

                    else if (d1.isValidPostalCode(PostalCodeTb.Text))
                    {
                        //Postal_Code = PostalCodeTb.Text;
                        errorProvider1.Clear();
                    }

                    break;

                case 1:
                    if (string.IsNullOrEmpty(PostalCodeTb.Text))
                    {
                        PostalCodeTb.Focus();
                        errorProvider1.SetError(PostalCodeTb, "Please Enter Your Postal Code !");
                    }

                    else if (!p.isValidPostalCode(PostalCodeTb.Text))
                    {
                        PostalCodeTb.Focus();
                        errorProvider1.SetError(PostalCodeTb, "Postal Code must be in numbers !");
                    }

                    else if (p.isValidPostalCode(PostalCodeTb.Text))
                    {
                        // Postal_Code = PostalCodeTb.Text;
                        errorProvider1.Clear();
                    }
                    break;
            }
        }

        private void txtback_Click(object sender, EventArgs e)
        {
            Console.Beep();
            this.Hide();
            First_Page f = new First_Page();
            f.ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FirstNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
