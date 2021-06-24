using System;
using ClassLibraryEngSoft.Factory;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication
{
    public class NameDoctorHandler : BaseHandler
    {
        public override object Authenticator(Request request)
        {
            if (request.Data is Doctor person)
            {
                bool aux = false;
                for (int i = 0; i < person.Name.Length; i++)
                {
                    if (!char.IsLetter(person.Name[i]))
                        aux = true;
                }

                if(aux)
                    request.ErrorMessage.Append("Nome com caracteres inválidos!! \n");
            }
            else
            {
                throw new NotSupportedException($"Invalid type {request.GetType()}!");
            }

            return base.Authenticator(request);
        }
    }
}