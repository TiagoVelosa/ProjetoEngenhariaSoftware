using System;
using System.Diagnostics;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Factory
{
    public class PersonFactory : IFactory
    {
       
        public static readonly string Client = "Client";
        public static readonly string Doctor = "Doctor";

        public object Create(string type)
        {
            Person person = null;
            if (type == Client)
                person = new Client();
            else if (type == Doctor)
                person = new Doctor();
            return person;
        }

    }
}