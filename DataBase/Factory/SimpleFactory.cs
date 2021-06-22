using DataBase.Modules;
using Microsoft.Extensions.Primitives;

namespace ClassLibraryEngSoft.Factory
{
    public class SimpleFactory
    {
        private static SimpleFactory _instance;

        public static SimpleFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SimpleFactory();
                }

                return _instance;
            }
        }
        
        public IFactory CreateFactory(FactoryType type)
        {
            switch (type)
            {
                case FactoryType.PersonFactory:
                    return new PersonFactory();
                    break;
                case FactoryType.ItemFactory:
                    return new ItemFactory();
                    break;
                default: return null;
            }
        }
    }
}