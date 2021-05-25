using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.EntityFrameworkCore;

namespace ProjetoEngenhariaSoftwareClassLibrary
{
    public class DatabaseQuerys
    {

        public DatabaseQuerys()
        {

        }

        private static DatabaseQuerys _instance;

        public static DatabaseQuerys Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DatabaseQuerys();
                }

                return _instance;
            }
        }

        public List<Client> GetClients()
        {
            var context = new BDContext();
            return context.Users.ToList();
        }

        public void InsertClient(string Username, string Password, string Name, string Cellphone)
        {
            var context = new BDContext();
            var client = new Client()
            {
                CellPhone = Cellphone,
                Username = Username,
                Name = Name,
                Password = Password


            };
            context.Users.Add(client);
            context.SaveChanges();

        }
    }
}