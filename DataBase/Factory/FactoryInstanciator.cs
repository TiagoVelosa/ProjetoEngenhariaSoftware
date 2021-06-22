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
        
        public enum Types
        {
            PersonFactory,
            ItemFactory
        }

        public IFactory CreateFactory(Types type)
        {
            IFactory factory = null;
            if (type == Types.PersonFactory)
                factory = new PersonFactory();
            else if (type == Types.ItemFactory)
                factory = new ItemFactory();

            return factory;
        }
    }
}