using DBAtsiskaitymas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                AllTrainers = context.Trainers/*.FromSqlRaw($"SELECT * FROM Trainers")*/.ToList<Trainer>();
            }

        }
        public List<Trainer> GetAllTrainers()
        {
            return AllTrainers;
        }

        public List<Trainer> GetTrainersWithoutSport()
        {
            return AllTrainers.Where(x => x.SportId == null).ToList();
        }

        public Trainer GetTrainerByNameAndSurname(string name, string surname)
        {
            return AllTrainers.Where(x => x.Name == name && x.Surname == surname).FirstOrDefault();
        }

        public Guid GetTrainersId(string trainerNameSurname)
        {
            var listNameSurname = trainerNameSurname.Split(' ').ToList();
            string name = listNameSurname[0];
            string surname = listNameSurname[1];

            var trainer = new TrainersRepository().GetTrainerByNameAndSurname(name, surname);
            return trainer.Id;
        }

        public Trainer GetTrainerById(Guid id)
        {
            return AllTrainers.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
