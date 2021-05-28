namespace DataBase.Modules
{
    public class Item
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int PrescriptionID { get; set; }

        public Prescription Prescription { get; set; }
    }
}