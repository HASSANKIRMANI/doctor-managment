using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT_WINDOW_FORM
{
    public interface IFixAppointment
    {
        int readEmptyLines();
        int readEmptyLines(string Doc);
        doctor fixAppointment(string patient_path, string doctor_path);
        string searchDoc(string doctor_suggested);
        void writeDoc_PatientFile(string doc);
        void writePatient_DocFile(string doc);
    }
}
