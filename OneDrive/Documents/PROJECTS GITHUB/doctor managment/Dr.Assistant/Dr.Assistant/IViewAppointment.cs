using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP_PROJECT_WINDOW_FORM
{
    public interface IViewAppointment
    {
        doctor viewAppointment(string patient_path,string doc_path);
        doctor showDetails(string Doc,string doctor_path);
    }
}
