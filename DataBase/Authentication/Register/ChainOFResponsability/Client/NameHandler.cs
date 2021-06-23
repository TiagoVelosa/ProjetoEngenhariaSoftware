using System.Text.RegularExpressions;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication
{
    public class NameHandler : BaseHandler
    {
        public override object Authenticator(Request request)
        {
            if (request.Data is Person person)
            {
                bool aux = false;
                for (int i = 0; i < person.name.Length; i++)
                {
                    if (!char.IsLetter(person.name[i]))
                        aux = true;
                }
                if(aux)
                    request.ErrorMessage.Append("Nome com caracteres inválidos!! \n");

            }

            return base.Authenticator(request);
        }
    }
}