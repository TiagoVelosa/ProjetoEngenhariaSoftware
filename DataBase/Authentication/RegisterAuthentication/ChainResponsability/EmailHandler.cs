using System.Net.Mail;
using System.Text.RegularExpressions;
using DataBase.Modules;
using System.Text.RegularExpressions;

namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication
{
    public class EmailHandler : BaseHandler
    {
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public override object Authenticator(Request request)
        {

            if (request.Data is Person person)
            {

                if (!IsValidEmail(person.email))
                {
                    request.ErrorMessage.Append("Email no formato inválido!! \n");
                }
                
            }

            return base.Authenticator(request);
        }
    }
}