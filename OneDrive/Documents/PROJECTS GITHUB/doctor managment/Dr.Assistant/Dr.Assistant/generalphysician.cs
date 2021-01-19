﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT_WINDOW_FORM
{
    class generalphysician : doctor
    {

        public generalphysician()
        {
            this._Fee = 800;
            this._description = "I'm a General Physician";
        }

        public generalphysician(string FirstName, string LastName, string Username, string Password, int Age, string PhoneNo, string Gender, string Speciality, string Address, string PostalCode, string EmailAddress)
            : base(FirstName, LastName, Username, Password, Age, PhoneNo, Gender, Speciality, Address, PostalCode, EmailAddress)
        {
            this._Fee = 800;
            this._description = "I'm a General Physician";
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
    }
}
