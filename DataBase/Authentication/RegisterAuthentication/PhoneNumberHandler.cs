using DataBase.Modules;

namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication
{
    public class PhoneNumberHandler : BaseHandler
    {

        public bool IsDigit(string number)
        {
            foreach (char n in number)
            {
                if (n < '0' || n > '9')
                    return true;
            }

            return false;
        }
        public override object Authenticator(Request request)
        {
            if (request.Data is Person person)
            {
                if (person.telefone[0] == '9' && person.telefone.Length == 9 && IsDigit(person.telefone))
                {
                    var querys = new DBQuerys();
                    var phonenumbers = querys.GetPhoneNumbers();
                    foreach (var number in phonenumbers)
                    {
                        if (person.telefone == number)
                            request.ErrorMessage.Append("Número de telemóvel inválido ou já existente!! \n");
                    }
                }
                else
                {
                    request.ErrorMessage.Append("Número de telemóvel inválido ou já existente!! \n");
                }

            }

            return base.Authenticator(request);
        }
    }
}