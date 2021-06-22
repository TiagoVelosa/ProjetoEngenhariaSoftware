using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository.TherapySessions
{
    public class TherapySessionRepository : Repository<TherapySession> , ITherapySessionRepository
    {
        public TherapySessionRepository(PrescriptionContext context) : base(context)
        {

        }


        public IEnumerable<TherapySession> GetTherapySessionsByDoctor(string name)
        {
            return PrescriptionContext.TherapySessions.Where(e => e.Doctor.name == name);
        }

        public PrescriptionContext PrescriptionContext
        {
            get { return Context as PrescriptionContext;}
        }
    }
}