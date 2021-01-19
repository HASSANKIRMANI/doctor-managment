using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OOP_PROJECT_WINDOW_FORM
{
    public class Patient
    {
        string FirstName;
        string LastName;
        int Age;
        string PhoneNo;
        string Gender;
        string Address;
        string PostalCode;
        string Username;
        string Password;
        string EmailAddress;

        public Patient()
        {
            Age = 0;
            PhoneNo = " ";
            FirstName = " ";
            LastName = " ";
            Username = " ";
            Password = " ";
            Gender = " ";
            Address = " ";
            PostalCode = " ";
            EmailAddress = " ";
        }

        public Patient(int Age, string PhoneNo, string FirstName, string LastName, string Username,
            string Password, string Gender, string Address, string PostalCode, string EmailAddress)
        {
            this._Age = Age;
            this._FirstName = FirstName;
            this._LastName = LastName;
            this._Password = Password;
            this._Username = Username;
            this._PhoneNo = PhoneNo;
            this._Gender = Gender;
            this._Address = Address;
            this._PostalCode = PostalCode;
            this._EmailAddress = EmailAddress;
        }

        //Age

        public int _Age
        {
            set
            {
                if (isValidAge(value)) { this.Age = value; }
                else { this.Age = 0; }
            }
            get
            {
                return this.Age;
            }
        }
        public bool isValidAge(int Age) { return (Age > 0); }


        //Username
        public string _Username
        {
            set
            {
                if (isValidUsername(value)) { this.Username = value; }
                else { this.Username = " "; }
            }
            get
            {
                return this.Username;
            }
        }
        public bool isValidUsername(string Username)
        {
            int flag = 0, i;
            for (i = 0; i < Username.Length; i++)
            {
                if (Username[i] == ' ')
                {
                    flag = 1; break;
                }
            }
            if (flag == 0) { return true; }
            else { return false; }
        }


        //firstName

        public string _FirstName
        {
            set
            {
                if (isValidFirstName(value)) { this.FirstName = value; }
                else { this.FirstName = " "; }
            }
            get
            {
                return this.FirstName;
            }
        }
        public bool isValidFirstName(string FirstName)
        {
            int i;
            int flag = 0;
            for (i = 0; i < FirstName.Length; i++)
            {
                if (FirstName[i] >= 'a' && FirstName[i] <= 'z' || FirstName[i] >= 'A' && FirstName[i] <= 'Z')
                {
                    continue;
                }
                else
                {
                    flag = 1; break;
                }
            }

            if (flag == 0) { return true; }
            else
            {
                return false;
            }
        }



        //lastName

        public string _LastName
        {
            set
            {
                if (isValidLastName(value))
                {
                    this.LastName = value;
                }
                else
                {
                    this.LastName = " ";
                }
            }
            get { return this.LastName; }
        }

        public bool isValidLastName(string LastName)
        {
            int i;
            int flag = 0;
            for (i = 0; i < LastName.Length; i++)
            {
                if (LastName[i] >= 'a' && LastName[i] <= 'z' || LastName[i] >= 'A' && LastName[i] <= 'Z')
                {
                    continue;
                }
                else
                {
                    flag = 1; break;
                }
            }

            if (flag == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        //password

        public bool isValidPassword(string password)
        {
            if(password.Length >= 8) { return true; }
            else { return false; }
        }
        public string _Password
        {
            set
            {
                if (isValidPassword(value))
                {
                    this.Password = value;
                }
                else
                {
                    this.Password = " ";
                }
            }
            get { return Password; }
        }

        //gender

        public string _Gender
        {
            set { this.Gender = value; }
            get { return Gender; }
        }

        //address  

        public string _Address
        {
            set
            {
                this.Address = value;
            }
            get { return Address; }
        }


        //Postal Code
        public string _PostalCode
        {
            set
            {
                if (isValidPostalCode(value))
                {
                    this.PostalCode = value;
                }
                else
                {
                    this.PostalCode = " ";
                }
            }
            get
            {
                return PostalCode;
            }
        }
        public bool isValidPostalCode(string PostalCode)
        {
            int flag = 0;
            int i;
            for (i = 0; i < PostalCode.Length; i++)
            {
                if ((PostalCode[i] < '0' || PostalCode[i] > '9'))
                {
                    flag = 1; break;
                }
            }
            if (flag == 0)
                return true;
            else
                return false;
        }


        //phone number

        public string _PhoneNo
        {
            set
            {
                if (isValidPhoneNo(value))
                {
                    this.PhoneNo = value;
                }
                else
                {
                    this.PhoneNo = " ";
                }
            }
            get { return this.PhoneNo; }

        }
        public bool isValidPhoneNo(string PhoneNo = null)
        {
            if (PhoneNo == null) { return false; }
            int i;

            try
            {
                if (PhoneNo[4] == '-' && PhoneNo.Length == 12)
                {
                    for (i = 0; i < 4; ++i)
                    {
                        if (PhoneNo[i] >= '0' && PhoneNo[i] <= '9') continue;
                        else break;
                    }
                    if (i == 4)
                    {
                        for (i = 5; i < 12; ++i)
                        {
                            if (PhoneNo[i] >= '0' && PhoneNo[i] <= '9') continue;
                            else break;
                        }

                        if (i == 12) { return true; }
                        else { return false; }
                    }
                    else { return false; }
                }
                else { return false; }
            }
            catch { return false; }
        }

        //Email Address

        public bool isValidEmail(string source)
        {
            return new EmailAddressAttribute().IsValid(source);
        }

        public string _EmailAddress
        {
            set
            {
                if (isValidEmail(value))
                {
                    this.EmailAddress = value;
                }
            }
            get
            {
                return this.EmailAddress;
            }
        }


    }
}
