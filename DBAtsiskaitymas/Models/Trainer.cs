

namespace DBAtsiskaitymas.Models
{
    public class Trainer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? SportId { get; set; }
        public List<TrainerClient> TrainersClients { get; set; }
        public Trainer(string name, string surname, int? sportId)
        {
            Id = new Guid();
            Name = name;
            Surname = surname;
            SportId = sportId;
            TrainersClients = new List<TrainerClient>();
        }
    }
}
