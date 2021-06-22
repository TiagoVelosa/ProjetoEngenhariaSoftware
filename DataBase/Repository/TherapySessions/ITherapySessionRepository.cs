using System.Collections.Generic;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository.TherapySessions
{
    public interface ITherapySessionRepository : IRepository<TherapySession>
    {
        TherapySession GetTherapySessionsByTitle(string title);
        IEnumerable<TherapySession> GetTherapySessionsByDoctor(string name);
        IEnumerable<TherapySession> GetTherapySessionsByDoctorNotDone(string name);
    }
}