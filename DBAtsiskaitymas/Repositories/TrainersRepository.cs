using DBAtsiskaitymas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub.Repositories
{
    public class TrainersRepository
    {
        public List<Trainer> AllTrainers { get; set; }
        public TrainersRepository()
        {
            AllTrainers = new List<Trainer>();
            using (var context = new SportClubDBContext())
            {
                AllTrainers = context.Trainers.FromSqlRaw($"SELECT * FROM Trainers").ToList<Trainer>();
            }

        }
        public List<Trainer> GetAllTrainers()
        {
            return AllTrainers;
        }
    }
}
