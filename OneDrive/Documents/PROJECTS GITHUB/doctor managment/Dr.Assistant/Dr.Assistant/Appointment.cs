using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_PROJECT_WINDOW_FORM
{
    class Appointment :  IFixAppointment,IViewAppointment
    {
        public doctor doc;

        string username;

        public Appointment(string username)
        {
            this.username = username;
        }

        public string _username
        {
            set
            {
                this.username = value;
            }
            get
            {
                return username;
            }
        }

        public doctor fixAppointment(string patient_path, string doctor_path)
        {
            int lineCount = 0;
            int cnt = 0;
            string line;

            string disease_predicted;
            string doctor_suggested;

            lineCount = readEmptyLines();

            StreamReader sr = null;
            try
            {
                sr = new StreamReader(patient_path + username + ".txt");
            }
            catch (Exception e) { e.Message.ToString(); }

            while (true)
            {
                line = sr.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    cnt += 1;
                    if (cnt == lineCount - 1)
                    {
                        break;
                    }
                }
            }

            while (true)
            {
                if ((line = sr.ReadLine()) == "Symptoms End")
                {
                    break;
                }
            }

            disease_predicted = sr.ReadLine();
            doctor_suggested = sr.ReadLine();

            sr.Close();

            string doc = searchDoc(doctor_suggested);

            if (doc != null)
            {
                doctor d = new generalphysician();
                writePatient_DocFile(doc);  //writing patient name in doctor file
                writeDoc_PatientFile(doc);  //writing doctor name in patient file
                d = showDetails(doc, doctor_path);
                return d;
            }
            else
            {
                doctor d = null;
                writeDoc_PatientFile("-");  //writing doctor name in patient file
                return d;
            }
            //Function bracket
        }

        public int readEmptyLines()
        {
            string line;
            int count = 0;
            StreamReader sr = null;
            //          MessageBox.Show("In Read");
            try
            {
                sr = new StreamReader(First_Page.pat_path + username + ".txt");
            }
            catch (Exception e) { e.Message.ToString(); }

            while (true)
            {
                line = sr.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    count += 1;
                }
                if (line == null)
                {
                    break;
                }
            }

            sr.Close();

            return count;
        } //readline bracket

        public int readEmptyLines(string user) //Function Overloading
        {
            string line;
            int count = 0;
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(First_Page.doc_path + user + ".txt");
            }
            catch (Exception e){ e.Message.ToString(); }

            while (true)
            {
                line = sr.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    count += 1;
                }
                if (line == null)
                {
                    break;
                }
            }

            sr.Close();

            return count;

        }//function bracket

        public string searchDoc(string doctor_suggested)
        {
            string user, speciality, line;

            int count;

            string temp = null;

            int min = 9999;

            bool flag = false;
            bool minFound = false;

            StreamReader doc = null;
            StreamReader sr = null;

            try
            {
                doc = new StreamReader(First_Page.doc_path + "usernames.txt");
            }
            catch (Exception e) { e.Message.ToString(); }

            while (true)
            {
                user = doc.ReadLine();
                if (user == null)
                {
                    break;
                }

                try
                {
                    sr = new StreamReader(First_Page.doc_path + user + ".txt");
                }
                catch(Exception e) { e.Message.ToString(); }

                for (int i = 0; i < 6; ++i)
                {
                    line = sr.ReadLine();
                }
                speciality = sr.ReadLine();

                sr.Close();

                if (speciality == doctor_suggested)
                {
                    flag = true;
                    count = readEmptyLines(user);
                    if (count < min)
                    {
                        minFound = true;
                        min = count;
                        temp = user;
                    }

                    if (count == 1)
                        break;
                    else
                    {
                        flag = false;
                        continue;
                    }
                }
            }

            doc.Close();

            if (flag == true || minFound == true)
                return temp;

            else
                return null;
        }//function bracket

        public void writePatient_DocFile(string doc)
        {
            StreamWriter sw = null;
            try
            {
                sw = File.AppendText(First_Page.doc_path + doc + ".txt");
            }
            catch (Exception e) { e.Message.ToString(); }

            sw.WriteLine();
            sw.WriteLine(this.username); //writing patient Username in the Doctors File 
            sw.Close();
        }

        //Writing Doc name in patient file
        public void writeDoc_PatientFile(string doc)
        {
            StreamWriter sw = null;
            try
            {
                sw = File.AppendText(First_Page.pat_path + this.username + ".txt");
            }
            catch(Exception e){ e.Message.ToString(); }

            sw.WriteLine(doc);
            sw.Close();
        }


        //Implementation for ViewAppointment Interface

        public doctor showDetails(string Doc, string doc_path)
        {

            string trash;
            doc = new generalphysician();

            StreamReader sr = null;
            try
            {
                sr = new StreamReader(doc_path + Doc + ".txt");
            }
            catch (Exception e) { e.Message.ToString(); }

            doc._FirstName = sr.ReadLine();
            doc._LastName = sr.ReadLine();
            doc._Username = sr.ReadLine();

                trash = sr.ReadLine();
            

            doc._Age = Int32.Parse(sr.ReadLine());

            trash = sr.ReadLine();

            doc._Speciality = sr.ReadLine();
            doc._PhoneNo = sr.ReadLine();

            for (int i = 0; i < 2; ++i)
            {
                trash = sr.ReadLine();
            }

            doc._Fee = Double.Parse(sr.ReadLine());

            sr.Close();

            return doc;
        }

        public doctor viewAppointment(string patient_path, string doc_path)
        {
            string docName = null;
            int lineCount = 0, cnt = 0;
            string trash = null;

            doctor d = null;

            lineCount = readEmptyLines();
          
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(patient_path + this.username + ".txt"); //opening username(patient) file
            }
            catch(Exception e)
            {
                e.Message.ToString();
            }

            if (lineCount == 1) { return d; }

            while (true)
            {
                trash = sr.ReadLine();
                if (string.IsNullOrEmpty(trash))
                {
                    cnt += 1;
                    if (cnt == lineCount - 1)
                    {
                        break;
                    }
                }
            }

            while (true)
            {
                if ((trash = sr.ReadLine()) == "Symptoms End")
                {
                    break;
                }
            }

            for (int i = 0; i < 2; ++i)
                trash = sr.ReadLine();

            docName = sr.ReadLine();
            if (docName != "-")
            {
                d = showDetails(docName, doc_path);
            }
            else
            {
                return null;
            }
            sr.Close();
            return d;

        }
        
    }
}