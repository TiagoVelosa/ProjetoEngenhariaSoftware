using DataBase.Modules;
using Microsoft.Extensions.Primitives;

namespace ClassLibraryEngSoft.Factory
{
    public class FactoryInstanciator
    {
        private static FactoryInstanciator _instance;

        public static FactoryInstanciator Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FactoryInstanciator();
                }

                return _instance;
            }
        }
        public FactoryInstanciator()
        {

        }

        public static readonly string PersonFactory = "Person";
        public static readonly string ItemFactory = "Item";

        public IFactory CreateFactory(string type)
        {
            IFactory factory = null;
            if (type == PersonFactory)
                factory = new PersonFactory();
            else if (type == ItemFactory)
                factory = new ItemFactory();

            return factory;
        }
    }
}