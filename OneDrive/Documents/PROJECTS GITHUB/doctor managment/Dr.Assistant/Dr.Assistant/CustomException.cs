using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT_WINDOW_FORM
{
    class CustomException : Exception
    {
        string msg;

        //when throwing any string this constructor would invoke
        public CustomException(string msg)
        {
            this.msg= msg;
        }

        //Overriding the member variable of exception class to override its functionality
        public override string Message
        {
            get
            {
                return this.msg;
            }
        }
    }
}
