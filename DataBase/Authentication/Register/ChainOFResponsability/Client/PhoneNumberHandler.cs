using ClassLibraryEngSoft.Repository;
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
                    return false;
            }

            return true;
        }
        public override object Authenticator(Request request)
        {
            if (request.Data is Person person)
            {
                if (person.telefone[0] == '9' && person.telefone.Length == 9 && IsDigit(person.telefone))
                {
                    var repository = new UnitOfWork.UnitOfWork(new PrescriptionContext());
                    var phonenumbers = repository.Persons.GetPhoneNumbers();
                    if (phonenumbers.Contains(person.telefone)) 
                        request.ErrorMessage.Append("Número de telemóvel já existente!! \n");
                    
                }
                else
                {
                    request.ErrorMessage.Append("Número de telemóvel inválido!! \n");
                }

            }

            return base.Authenticator(request);
        }
    }
}