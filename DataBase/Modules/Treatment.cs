namespace DataBase.Modules
{
    public class Treatment : Item
    {
        public string Description { get; set; }

        public bool Done { get; set; }

        public TherapySession Session { get; set; }

    }
}