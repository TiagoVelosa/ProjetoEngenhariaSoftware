using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using DataBase.Modules;


namespace ClassLibraryEngSoft.Authentication.LoginAuthentication
{
    public class LoginAuthenticator
    {
        private readonly string Username;
        private readonly string Password;
        public LoginAuthenticator(string username,string password)
        {
            Username = username;
            Password = password;
        }

        /*public bool IsLoginValid()
        {
            var querys = new DBQuerys();
            var persons = querys.GetPersons();
            foreach (var person in persons)
            {
                if (Username == person.username)
                    if (isPasswordValid(person))
                        return true;
            }

            return false;

        }*/

        /*public bool isPasswordValid(Person person)
        {
            if (person.password == Password)
                return true;
            return false;

        }*/

    }
}