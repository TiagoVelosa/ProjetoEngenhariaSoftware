using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using ClassLibraryEngSoft.UnitOfWork;
using DataBase.Modules;


namespace ClassLibraryEngSoft.Authentication.LoginAuthentication
{
    public class LoginAuthenticator
    {

        private Credentials _credentials;
        public LoginAuthenticator(Credentials credentials)
        {
            _credentials = credentials;
        }


        public bool CheckPassword(string Password)
        {
            if (_credentials.Password == Password)
                return true;
            return false;
        }

        public string CheckRole()
        {
            if (_credentials.Person.Type == "Client")
                return "Client";
            return "Doctor";
        }
        

    }
}