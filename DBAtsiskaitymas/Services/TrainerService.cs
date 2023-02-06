using DBAtsiskaitymas.Models;
using SportClub.Repositories;

namespace SportClub.Services
{
    public class TrainerService
    {
        public void RegisterNewTrainer(string name, string surname, int? sportId)
        {
            using (var db = new SportClubDBContext())
            {
                var trainer = new Trainer(name, surname, sportId);
                db.Trainers.Add(trainer);
                db.SaveChanges();
            }

        }
        public void AddSportForTrainer(string trainerNameSurname, string sportName)
        {
            var sport = new SportsRepository();
            int? sportId = sport.SportsIdByName(sportName);

            var listNameSurname = trainerNameSurname.Split(' ').ToList();
            string name = listNameSurname[0];
            string surname = listNameSurname[1];

            var trainersRepository = new TrainersRepository();
            var trainer = trainersRepository.GetTrainerByNameAndSurname(name, surname);
            trainer.SportId = sportId;

            using (var db = new SportClubDBContext())
            {
                db.Trainers.Update(trainer);
                db.SaveChanges();
            }
        }
        public void DeleteTrainersClients(string trainerNameSurname)        
        {
            var listNameSurname = trainerNameSurname.Split(' ').ToList();
            string name = listNameSurname[0];
            string surname = listNameSurname[1];

            var trainersRepository = new TrainersRepository();
            var trainer = trainersRepository.GetTrainerByNameAndSurname(name, surname);
            var trainerId = trainer.Id;

            using (var db = new SportClubDBContext())
            {
                var trainerClients = db.TrainersClients
                                     .Where(tc => tc.TrainersId == trainerId)
                                     .ToList();
                db.TrainersClients.RemoveRange(trainerClients);
                db.SaveChanges();
            }
        }
    }
}
