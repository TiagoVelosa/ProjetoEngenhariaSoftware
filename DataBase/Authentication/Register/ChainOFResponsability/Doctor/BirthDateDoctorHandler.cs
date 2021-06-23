using System;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication
{
    public class BirthDateDoctorHandler : BaseHandler
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
            if (request.Data is Doctor person)
            {
                var age = GetAge(person.datebirth);
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