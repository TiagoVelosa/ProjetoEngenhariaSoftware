using System;
using System.Collections;
using System.Collections.Generic;

namespace DataBase.Modules
{
    public class TherapySession
    {
        public int ID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }


        public int DoctorID { get; set; }

        public Doctor Doctor { get; set; }

        public IList<Treatment> Treatments { get; } = new List<Treatment>();
    }
}