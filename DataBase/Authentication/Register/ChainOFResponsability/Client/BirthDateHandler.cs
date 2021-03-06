using System;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication
{
    public class BirthDateHandler : BaseHandler
    {

        int GetAge(DateTime bornDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - bornDate.Year;
            if (bornDate > today.AddYears(-age))
                age--;

            return age;
        }
        public override object Authenticator(Request request)
        {
            if (request.Data is Person person)
            {
                var age = GetAge(person.Datebirth);
                if (age < 18)
                {
                    request.ErrorMessage.Append("Data de Nascimento Inválida!! \n");
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