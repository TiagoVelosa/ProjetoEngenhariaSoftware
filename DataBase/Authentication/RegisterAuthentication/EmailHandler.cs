using System.Net.Mail;
using System.Text.RegularExpressions;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication
{
    public class EmailHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data is Person person)
            {
                var format = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$");
                if (!format.IsMatch(person.email))
                    request.ErrorMessage.Append("Email no formato inválido!! \n");

                if(_nextHandler != null) 
                    _nextHandler.Process(request);
            }
        }
    }
}