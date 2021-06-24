using System;
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
                if (person.Telefone[0] == '9' && person.Telefone.Length == 9 && IsDigit(person.Telefone))
                {
                    var repository = new UnitOfWork.UnitOfWork(new PrescriptionContext());
                    var phonenumbers = repository.Persons.GetPhoneNumbers();
                    if (phonenumbers.Contains(person.Telefone)) 
                        request.ErrorMessage.Append("Número de telemóvel já existente!! \n");
                    
                }
                else
                {
                    request.ErrorMessage.Append("Número de telemóvel inválido!! \n");
                }

            }
            else
            {
                throw new NotSupportedException($"Invalid type {request.GetType()}!");
            }

            return base.Authenticator(request);
        }
    }
}