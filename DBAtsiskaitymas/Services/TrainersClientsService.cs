using DBAtsiskaitymas.Models;
using SportClub.Repositories;

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
