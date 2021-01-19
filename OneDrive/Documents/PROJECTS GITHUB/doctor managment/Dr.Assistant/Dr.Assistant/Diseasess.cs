using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT_WINDOW_FORM
{
    class Diseasess
    {
        static int[] count;
        
        string disease_predicted;
        string doctor_suggest;

        public Diseasess() { }
        //This constructor would invoke from Diagnosis page
        //This list is an dynamic array of strings Bcz we don't know how many symptoms user has selected at runtime
        public Diseasess(List<string> illness)
        {
            count = new int[8];

            for (int i = 0; i < 8; ++i)
                count[i] = 0;

            coronaviruscount(illness);
            respiratoryproblemcount(illness);
            heartproblemcount(illness);
            StrepThroatcount(illness);
            EarInfectionscount(illness);
            Diarrheacount(illness);
            allergycount(illness);
            ColdandFlucount(illness);

            //To calculate maximum selected disease count !!
            systemprediction();
        }

        public string _disease_predicted
        {
            set
            {
                this.disease_predicted = value;
            }
            get
            {
                return disease_predicted;
            }
        }

        public string _doctor_suggest
        {
            set
            {
                this.doctor_suggest = value;
            }
            get
            {
                return this.doctor_suggest; ;
            }
        }

        void coronaviruscount(List<string> illness)    //Go to Self quarantine
        {
            List<string> coronavirus = new List<string>() { "Dry cough", "Fever", "Body Ache", "Headache", "Sore throat", "Loss of Speech and Movement" };//Body Ache instead of tiredness
            foreach (string ill in illness)
            {
                foreach (string Corona in coronavirus)
                {
                    if (ill == Corona)
                        count[0]++;
                }
            }
        }

        void respiratoryproblemcount(List<string> illness) //Pulmonologist
        {
            List<string> respiratoryproblem = new List<string>() { "Trouble breathing", "Extreme tiredness", "Asthma that's hard to control", "Sweating or chills", "Breathing Noisly", "Stubborn Cough" }; //Pulmonologist                                                                                                               //int respiratoryproblem_count = 0;
            foreach (string ill in illness)
            {
                foreach (string Res in respiratoryproblem)
                {
                    if (ill == Res)
                        count[1]++;
                }
            }
        }

        void heartproblemcount(List<string> illness)   //Cardiologist
        {
            List<string> heartproblem = new List<string>() { "Chest pain", "Shortness of breath", "Irregular heartbeat", "Swollen Feet or Swollen Ankles , Legs and Abdomen", "Fluttering in chest", "Chest Tightness" }; //Cardiologist                                                                                                     //int heartproblem_count = 0;
            foreach (string ill in illness)
            {
                foreach (string Heart in heartproblem)
                {
                    if (ill == Heart)
                        count[2]++;
                }
            }
        }



        void StrepThroatcount(List<string> illness)   //Otolaryngologists
        {
            List<string> StrepThroat = new List<string>() { "Difficulty swallowing", "Enlarged tonsils", "White patches on back of the throat", "Red and Swollen Tonsils", "Fatigue", "Body Pain" }; //Otolaryngologists//int StrepThroat_count = 0;
            foreach (string ill in illness)
            {
                foreach (string Strep in StrepThroat)
                {
                    if (ill == Strep)
                        count[3]++;
                }
            }
        }

        void EarInfectionscount(List<string> illness)  //Otolaryngologists
        {
            List<string> EarInfections = new List<string>() { "Muffled Hearing", "Fever", "Loss of balance", "Difficulty hearing", "Ear Drainage", "Ear Ache" }; //Otolaryngologists                                                                                   //int EarInfections_count = 0;
            foreach (string ill in illness)
            {
                foreach (string Ear in EarInfections)
                {
                    if (ill == Ear)
                        count[4]++;
                }
            }
        }

        void Diarrheacount(List<string> illness)   //General physician
        {
            List<string> Diarrhea = new List<string>() { "Loose stools", "Abdominal Cramps", "Nausea", "Fever", "Bloody stools", "Bloating" }; //general physician                                                            //int Diarrhea_count = 0;
            foreach (string ill in illness)
            {
                foreach (string Diar in Diarrhea)
                {
                    if (ill == Diar)
                        count[5]++;
                }
            }
        }

        void allergycount(List<string> illness)//General physician
        {

            List<string> allergie = new List<string>() { "Eye irritation", "Scratchy Throat", "Stuffy nose", "Watery eyes", "SneezingInflamed", "Sinus Pressure" };  //general physician                                                                                                                                          //int allergy_count = 0;
            foreach (string ill in illness)
            {
                foreach (string aller in allergie)
                {
                    if (ill == aller)
                        count[6]++;
                }
            }
        }

        void ColdandFlucount(List<string> illness) //General physician
        {
            List<string> ColdandFlu = new List<string>() { "Fever", "Headache", "Body pain", "Dry cough", "Mild tiredness", "Severe Muscle or Body Aches" }; //general physician                                                                                                                    //int ColdandFlu_count = 0;
            foreach (string ill in illness)
            {
                foreach (string Cold in ColdandFlu)
                {
                    if (ill == Cold)
                        count[7]++;
                }
            }
        }



        void systemprediction()
        {

            int max = 0, maxi = 0;
            for (int i = 0; i < 8; ++i)
            {
                if (count[i] > max)
                {
                    max = count[i];
                    maxi = i;
                }
            }

            if (max == 0) //validation if no symptoms are added
            {
                doctor_suggest = null;
            }
            else
            {
                if (maxi == 0)
                {
                    disease_predicted = "Corona Virus Predicted !";
                    doctor_suggest = "Infectologist";
                }

                if (maxi == 1)
                {
                    disease_predicted = "Respiratory Problem Symptoms";
                    doctor_suggest = "Pulmonologist";
                }

                if (maxi == 2)
                {
                    disease_predicted = "Heart Problem Symptoms";
                    doctor_suggest = "Cardiologist";
                }


                if (maxi == 3)
                {
                    disease_predicted = "Strep Throat Symptoms";
                    doctor_suggest = "Otolaryngologist";
                }

                if (maxi == 4)
                {
                    disease_predicted = "Ear Infection Symptoms";
                    doctor_suggest = "Otolaryngologist";
                }

                if (maxi == 5)
                {
                    disease_predicted = "Diarrhea Symptoms Detected!";
                    doctor_suggest = "General Physician";
                }

                if (maxi == 6)
                {
                    disease_predicted = "Allergie Symptoms Detected!";
                    doctor_suggest = "General Physician";
                }

                if (maxi == 7)
                {
                    disease_predicted = "Cold and Flu Symptoms";
                    doctor_suggest = "General Physician";
                }

            }

        }
    }
}

