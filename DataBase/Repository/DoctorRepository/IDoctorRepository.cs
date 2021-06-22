using System.Collections.Generic;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public interface IDoctorRepository : IRepository<Doctor>
    {
        Doctor GetDoctorByName(string name);
    }
}