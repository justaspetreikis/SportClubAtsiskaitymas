using DBAtsiskaitymas.Models;

namespace SportClub.Repositories
{
    public class SportsRepository
    {
        public List<Sport> AllSports { get; set; }
        public SportsRepository()
        {
            using (var context = new SportClubDBContext())
            {
                AllSports = context.Sports.ToList<Sport>();
            }
             
        }
        public List<Sport> GetAllSports()
        {
            return AllSports;
        }

        public int? SportsIdByName(string name)
        {
            var sport = AllSports.Where(x => x.Name == name).FirstOrDefault();
            if(sport == null)
            {
                return null;
            }
            else
            {
                return sport.Id;
            }
           
        }
        public string GetSportNameById(int? id)
        {
            var sport = AllSports.Where(x => x.Id == id).FirstOrDefault();
            if (sport == null)
            {
                return "Trainer without sport Specialization";
            }
            else
            {
                return sport.Name;
            }

        }
        public int NextSportId()
        {
            return (AllSports.Count + 1);
        }
    }
}
