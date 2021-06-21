using System.Linq;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public class DoctorRepository : Repository<Doctor> , IDoctorRepository
    {
        public DoctorRepository(DBContext context) : base(context)
        {

        }


    }
}