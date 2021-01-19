using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT_WINDOW_FORM
{
    interface INotifyUsers
    {
        void notifyPatient(doctor doc);
        void notifyDoctor(doctor doc);
    }
}
