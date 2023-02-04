using DBAtsiskaitymas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub.Services
{
    public class ClientService
    {
        public void RegisterNewClient(string name, string surname, long IDNumber, DateTime time)
        {
            using (var db = new SportClubDBContext())
            {
                var client = new Client(name, surname, IDNumber, time);
                db.Clients.Add(client);
                db.SaveChanges();
            }         

        }
    }
}
