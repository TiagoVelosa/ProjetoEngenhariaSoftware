using System;

namespace ProjetoEngSoftClassLibrary.Models
{
    public class Prescription
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public DateTime Published { get; set; }


        public int PacienteID { get; set; }

        public Client Paciente { get; set; }

        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }




    }
}