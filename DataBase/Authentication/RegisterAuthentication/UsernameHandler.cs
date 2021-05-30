﻿using DataBase.Modules;

namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication
{
    public class UsernameHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data is Person person)
            {
                var querys = new DBQuerys();
                var usernames = querys.GetUsernames();
                foreach (var username in usernames)
                {
                    if (person.username == username)
                    {
                        request.ErrorMessage.Append("Username already exists!! \n");
                    }
                }

                if (_nextHandler != null)
                {
                    _nextHandler.Process(request);
                }

            }
        }
    }
}