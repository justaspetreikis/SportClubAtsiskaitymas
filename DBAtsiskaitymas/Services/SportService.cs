using DBAtsiskaitymas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
