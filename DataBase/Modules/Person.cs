using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Modules
{
    public class Person
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Telefone { get; set; }
        public string Type { get; set; }
        public DateTime Datebirth { get; set; }
        public int CredentialsId { get; set; }
        public Credentials Credentials { get; set; }

    }
}
