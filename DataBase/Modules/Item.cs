namespace DataBase.Modules
{
    public class Item 
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public bool IsVisible { get; set; }

        public string Type { get; set; }

        public Prescription Prescription { get; set; }


    }
}