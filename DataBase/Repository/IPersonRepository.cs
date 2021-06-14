using System.Collections.Generic;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        IList<string> GetPhoneNumbers();
    }
}