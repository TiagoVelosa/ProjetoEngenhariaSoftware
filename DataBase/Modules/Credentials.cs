using System;

namespace DataBase.Modules
{
    public class Credentials
    {
        public int ID { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public Person Person { get; set; }
    }
}