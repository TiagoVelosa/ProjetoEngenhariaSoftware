using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Modules
{
    public class Prescription
    {
        public int ID { get; set; }
        public string title { get; set; }
        public DateTime prescriptiondate { get; set; }

        public int ClientID { get; set;}

        public Client Client { get; set;}

        public int DoctorID { get; set; }
        public Doctor Doctor { get; set;}
    }
}
