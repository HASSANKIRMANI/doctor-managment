using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT_WINDOW_FORM
{
    //Singleton Class
    class AdminClass
    {

        //Constants so that cannot be changed throughout the program
        //Constants should be initialized when declared
        const string username = "admin";
        const string password = "admin123";


        //Private Constructor so that no object can be made by directly calling the constructor 
        private AdminClass() { } //private constructor

        //Static Function can use static variable directly 
        //Static function 
        private static AdminClass instance;

        public static AdminClass create_Instance()
        {
            if(instance == null) //this "if" will be true only when first time intance is created
            {
                instance = new AdminClass();
            }
                return instance;
            //This will return the saved instance everytime whenever create_Instance() is called bcz instance is static !
        }

        //Properties

        public string _username
        {
            get { return username; }
        }

        public string _password
        {
            get { return password; }
        }

    }
}
