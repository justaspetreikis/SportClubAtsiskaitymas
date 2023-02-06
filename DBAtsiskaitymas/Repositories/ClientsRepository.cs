using DBAtsiskaitymas.Models;

namespace SportClub.Repositories
{
    public class ClientsRepository
    {
        public List<Client> AllCLients { get; set; }
        public ClientsRepository()
        {
            using var context = new SportClubDBContext();
            AllCLients = context.Clients.ToList<Client>();
        }
        public List<Client> GetAllClients()
        {
            return AllCLients;
        }

        public Client GetClientByNameAndSurname(string name, string surname)
        {
            return AllCLients.Where(x => x.Name == name && x.Surname == surname).FirstOrDefault();
        }

        public Guid GetClientId(string clientNameSurname)
        {
            var listNameSurname = clientNameSurname.Split(' ').ToList();
            string name = listNameSurname[0];
            string surname = listNameSurname[1];

            var client = new ClientsRepository().GetClientByNameAndSurname(name, surname);
            return client.Id;
        }
    }
}
