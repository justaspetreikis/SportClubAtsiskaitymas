

namespace DBAtsiskaitymas.Models
{
    public class Sport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Trainer> Trainers { get; set; }
        public Sport(int id, string name)
        {
            Id = id;
            Name = name;
            Trainers = new List<Trainer>();
        }
    }
}
