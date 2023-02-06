using DBAtsiskaitymas.Models;

namespace SportClub.Repositories
{
    public class TrainerClientRepository
    {
        public List<TrainerClient> AllTrainersClients { get; set; }
        public TrainerClientRepository()
        {
            using (var context = new SportClubDBContext())
            {
                AllTrainersClients = context.TrainersClients.ToList<TrainerClient>();
            }
        }
        public List<TrainerClient> GetAllTrainersClients()
        {
            return AllTrainersClients;
        }
    }
}
