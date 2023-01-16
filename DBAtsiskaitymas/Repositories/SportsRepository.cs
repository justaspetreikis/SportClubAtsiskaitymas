using DBAtsiskaitymas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub.Repositories
{
    public class SportsRepository
    {
        public List<Sport> AllSports { get; set; }
        public SportsRepository()
        {
            AllSports = new List<Sport>();
            using (var context = new SportClubDBContext())
            {
                AllSports = context.Sports.FromSqlRaw($"SELECT * FROM Sports").ToList<Sport>();
            }
                
        }
        public List<Sport> GetAllSports()
        {
            return AllSports;
        }
    }
}
