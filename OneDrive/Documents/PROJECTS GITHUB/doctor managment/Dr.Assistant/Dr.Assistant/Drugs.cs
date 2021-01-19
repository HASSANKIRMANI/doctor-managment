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

    //To depict the drugs
    class Drugs
    {

        string drugType;
        string drugName;
        string drugStrenght;


        public Drugs()
        {
            drugType = " ";
            drugName = " ";
            drugStrenght = " ";
        }

        public Drugs(string drug_type, string drug_name, string drug_strength)
        {
            this._drugType = drugType;
            this._drugName = drugName;
            this._drugStrenght = drugStrenght;
        }

        //Drug type
        public string _drugType 
        {
            set
            {
                if (!isStringEmpty(value))
                {
                    this.drugType = value;
                }
            }
            get { return drugType; }
        }

        //drug name
        public string _drugName
        {
            set
            {
                if (!isStringEmpty(value))
                {
                    this.drugName = value;
                }
            }
            get { return drugName; }
        }

        //drug strength
        public string _drugStrenght
        {
            set
            {
                if (!isStringEmpty(value))
                {
                    this.drugStrenght = value;
                }
            }
            get { return drugStrenght; }
        }


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
