using System.Collections.Generic;

namespace ProjetoEngenhariaSoftwareClassLibrary.Authentication
{
    public class RegisterAuthentication
    {
        public bool CheckUsernameAvailability(string Username)
        {
            var clients = DatabaseQuerys.Instance.GetClients();
            foreach (var client in clients)
            {
                if (client.Username == Username)
                {
                    return false;
                }
            }

            return true;
        }
    }
}