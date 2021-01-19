using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT_WINDOW_FORM
{
    class pulmonologist : doctor
    {

        public pulmonologist()
        {
            this._Fee = 1500;
            this._description = "Pulmonologist is a medical specialist that deals with diseases involving the respiratory tract";
        }

        public pulmonologist(string FirstName, string LastName, string Username, string Password, int Age, string PhoneNo, string Gender, string Speciality, string Address, string PostalCode, string EmailAddress)
            : base(FirstName, LastName, Username, Password, Age, PhoneNo, Gender, Speciality, Address, PostalCode, EmailAddress)
        {
            this._Fee = 1500;
            this._description = "Pulmonologist is a medical specialist that deals with diseases involving the respiratory tract";
        }

        public override double _Fee
        {
            set
            {
                if (isFeeValid(value)) { Fee = value; }
            }
            get
            {
                return this.Fee;
            }
        }

        public override string _description
        {
            set
            {
                if (!isDescriptionEmpty(value))
                    this.description = value;
            }
            get
            {
                return this.description;
            }
        }

    }    //respiratory
}
