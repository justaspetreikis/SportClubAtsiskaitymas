using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAtsiskaitymas.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Created { get; set; }
        public List<TrainerClient> TrainersClients { get; set; }
        public Client(string name, string surname, DateTime created)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Created = created;
            TrainersClients = new List<TrainerClient>();
        }
    }
}
