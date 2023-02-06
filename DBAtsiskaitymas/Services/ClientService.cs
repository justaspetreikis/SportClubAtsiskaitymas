using DBAtsiskaitymas.Models;
using SportClub.Repositories;
using System.Xml.Linq;

namespace SportClub.Services
{
    public class ClientService
    {
        private readonly ClientsRepository _clientsRepository;

        public ClientService()
        {
            _clientsRepository = new ClientsRepository();
        }
        public void RegisterNewClient(string name, string surname, long IDNumber, DateTime time)
        {
            var existingClient = _clientsRepository.GetAllClients()
                .FirstOrDefault(x => x.IdentificationNumber == IDNumber);
            if (existingClient != null)
            {
                MessageBox.Show("Client with this ID number already exist");
                return;
            }

            var client = new Client(name, surname, IDNumber, time);

            using (var db = new SportClubDBContext())
            {
                db.Clients.Add(client);
                db.SaveChanges();
            }
            MessageBox.Show($"New client was added to Clients");

        }
    }
}
