using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Modules
{
    public class Prescription
    {
        public int ID { get; set; }
        public string title { get; set; }
        public DateTime PrescriptionDate { get; set; }

        public Client Client { get; set;}
        public Doctor Doctor { get; set;}

        public IList<Item> Items { get; } = new List<Item>();
    }
}
