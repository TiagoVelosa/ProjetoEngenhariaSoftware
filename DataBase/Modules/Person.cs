using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Modules
{
    public class Person
    {
        public int ID { get; set; }
        public string address { get; set; }
        public string name { get; set; }
        public string telefone { get; set; }
        public string Type { get; set; }
        public DateTime datebirth { get; set; }
        public int CredentialsID { get; set; }
        public Credentials Credentials { get; set; }

    }
}
