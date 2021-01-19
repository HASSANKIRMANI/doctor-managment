using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace OOP_PROJECT_WINDOW_FORM
{
    [Serializable]
    class Prescription : Drugs
    {
        string drugDose;
        string drugDuration;
        string drugAdvice;

        public Prescription():base()
        {
            drugDose = " ";
            drugDuration = " ";
            drugAdvice = " ";
        }
        public Prescription(string drug_type, string drug_name, string drug_strength, string drug_dose, string drug_duration, string drug_advice):base(drug_type,drug_name,drug_strength)
        {
            this._drugDose = drug_dose;
            this._drugDuration = drug_duration;
            this._drugAdvice = drug_advice;
        }

        //Drug Dose Property
        public string _drugDose
        {
            set
            {
                if (!isStringEmpty(value))
                {
                    drugDose = value;
                }
            }
            get
            {
                return drugDose;
            }
        }
        //Drug Duration Property
        public string _drugDuration
        {
            set
            {
                if (!isStringEmpty(value))
                {
                    drugDuration = value;
                }
            }
            get
            {
                return drugDuration;
            }
        }
        //Drug Advice property
        public string _drugAdvice
        {
            set
            {
                if (!isStringEmpty(value))
                {
                    drugAdvice = value;
                }
            }
            get
            {
                return drugAdvice;
            }
        }

         //validating Function
        bool isStringEmpty(string type)
        {
            if (string.IsNullOrEmpty(type))
            {
                return true;
            }
            else
            {
               return false;
            }
        }
    }
}
