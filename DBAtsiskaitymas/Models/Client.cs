
namespace DBAtsiskaitymas.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long IdentificationNumber { get; set; }
        public DateTime Created { get; set; }
        public List<TrainerClient> TrainersClients { get; set; }
        public Client(string name, string surname, long identificationNumber, DateTime created)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            IdentificationNumber = identificationNumber;
            Created = created;
            TrainersClients = new List<TrainerClient>();
        }
    }
}
