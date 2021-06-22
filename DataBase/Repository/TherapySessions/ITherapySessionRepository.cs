using System.Collections.Generic;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository.TherapySessions
{
    public interface ITherapySessionRepository
    {
        IEnumerable<TherapySession> GetTherapySessionsByDoctor(string name);
    }
}