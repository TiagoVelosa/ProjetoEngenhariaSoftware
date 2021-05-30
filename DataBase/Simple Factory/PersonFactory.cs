using DataBase.Modules;

namespace ClassLibraryEngSoft.Simple_Factory
{
    public class PersonFactory
    {
        public static readonly string Client = "Client";
        public static readonly string Doctor = "Doctor";

        public object Create(string type)
        {
            Person person;
            if (type == Client)
                person = new Client();
            else if (type == Doctor)
                person = new Doctor();
            else
                return null;
            return person;
        }
    }
}