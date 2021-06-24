using System.Linq;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public class DoctorRepository : Repository<Doctor> , IDoctorRepository
    {
        public DoctorRepository(PrescriptionContext context) : base(context)
        {

        }


        public Doctor GetDoctorByName(string name)
        {
            return PrescriptionContext.Doctors.FirstOrDefault(e => e.Name == name);
        }

        public PrescriptionContext PrescriptionContext
        {
            get { return Context as PrescriptionContext; }
        }
    }
}