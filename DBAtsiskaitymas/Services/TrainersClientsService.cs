using DBAtsiskaitymas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SportClub.Services
{
    public class TrainersClientsService
    {
        public void AddClientToTrainer(Guid trainerId, Guid clientId)
        {
            using (var db = new SportClubDBContext())
            {
                var trainerClient = new TrainerClient(trainerId, clientId);
                db.TrainersClients.Add(trainerClient);
                db.SaveChanges();
            }
        }
    }
}
