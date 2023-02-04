using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAtsiskaitymas.Models
{
    public class TrainerClient
    {
        public Guid TrainersId {get; set;}
        public Guid ClientsId {get; set;}
        public Trainer Trainer { get; set; }
        public Client Client { get; set; }

        public TrainerClient(Guid trainersId, Guid clientsId)
        {
            TrainersId = trainersId;
            ClientsId = clientsId;
        }
    }
}
