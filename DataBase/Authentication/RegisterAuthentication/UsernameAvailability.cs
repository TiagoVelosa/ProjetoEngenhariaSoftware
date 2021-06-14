using ClassLibraryEngSoft.Repository;
using DataBase.Modules;
using ClassLibraryEngSoft.UnitOfWork;

namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication
{
    public class UsernameAvailability
    {
        private IUnitOfWork _unit;
        public UsernameAvailability()
        {
            _unit = new UnitOfWork.UnitOfWork();
        }

        public bool CheckUsernameAvailability(string Username)
        {
            var usernames = _unit.Credentials.GetUsernames();
            foreach (var username in usernames)
            {
                if (username == Username) return false;
            }

            return true;
        }
    }
}
