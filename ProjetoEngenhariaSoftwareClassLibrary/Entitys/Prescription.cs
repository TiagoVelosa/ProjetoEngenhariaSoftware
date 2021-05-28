namespace ProjetoEngenhariaSoftwareClassLibrary
{
    public class Prescription
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public Client Pacient { get; set; }

        public Doctor Doctor { get; set; }


    }
}