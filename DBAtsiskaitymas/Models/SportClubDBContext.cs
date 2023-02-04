using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAtsiskaitymas.Models
{
    public class SportClubDBContext : DbContext
    {
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<TrainerClient> TrainersClients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer($"Data Source=LAPTOP-545SUS4B;Initial Catalog=SportClub;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrainerClient>().HasKey(c => new
            {
                c.TrainersId,
                c.ClientsId
            });

            modelBuilder.Entity<Trainer>().HasMany(x => x.TrainersClients).WithOne(x => x.Trainer).HasForeignKey(x => x.TrainersId);
            modelBuilder.Entity<Client>().HasMany(x => x.TrainersClients).WithOne(x => x.Client).HasForeignKey(x => x.ClientsId);

            modelBuilder.Entity<Sport>().Property(x => x.Id).ValueGeneratedNever();

        }
    }
}
