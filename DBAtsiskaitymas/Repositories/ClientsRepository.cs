using DBAtsiskaitymas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub.Repositories
{
    public class ClientsRepository
    {
        public List<Client> AllCLients { get; set; }
        public ClientsRepository()
        {
            AllCLients = new List<Client>();
            using (var context = new SportClubDBContext())
            {
                AllCLients = context.Clients.FromSqlRaw($"SELECT * FROM Clients").ToList<Client>();
            }

        }
        public List<Client> GetAllClients()
        {
            return AllCLients;
        }
    }
}
