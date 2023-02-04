using DBAtsiskaitymas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub.Repositories
{
    public class TrainerClientRepository
    {
        public List<TrainerClient> AllTrainersClients { get; set; }
        public TrainerClientRepository()
        {
            AllTrainersClients = new List<TrainerClient>();
            using (var context = new SportClubDBContext())
            {
                AllTrainersClients = context.TrainersClients.FromSqlRaw($"SELECT * FROM TrainersClients").ToList<TrainerClient>();
            }
        }
    }
}
