﻿using DataBase.Modules;

namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication
{
    public class NameDoctorHandler : BaseHandler
    {
        public override object Authenticator(Request request)
        {
            if (request.Data is Doctor person)
            {
                for (int i = 0; i < person.name.Length; i++)
                {
                    if (!char.IsLetter(person.name[i]))
                        request.ErrorMessage.Append("Nome com caracteres inválidos!! \n");
                }

            }

            return base.Authenticator(request);
        }
    }
}