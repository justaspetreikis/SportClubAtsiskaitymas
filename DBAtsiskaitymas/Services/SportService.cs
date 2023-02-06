using DBAtsiskaitymas.Models;
using SportClub.Repositories;

namespace SportClub.Services
{
    public class SportService
    {
        public void RegisterNewSport(int id, string name)
        {
            using (var db = new SportClubDBContext())
            {
                var sport = new Sport(id, name);
                db.Sports.Add(sport);
                db.SaveChanges();
            }

        }
    }
}
