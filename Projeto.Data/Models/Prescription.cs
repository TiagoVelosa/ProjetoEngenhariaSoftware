namespace Projeto.Data.Models
{
    public class Prescription
    {
        public int Id { get; set; }

        public string Title { get; set; }


        //Navigation Properties
        public int UserId { get; set; }

        public User User { get; set; }

        public int DoctorId { get; set; }

        public Doctor Doctor { get; set; }


    }
}