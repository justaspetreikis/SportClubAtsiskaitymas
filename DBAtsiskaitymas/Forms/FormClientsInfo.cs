using DBAtsiskaitymas;
using DBAtsiskaitymas.Models;
using Microsoft.EntityFrameworkCore;
using SportClub.Repositories;

namespace SportClub.Forms
{
    public partial class FormClientsInfo : Form
    {
        public FormClientsInfo()
        {
            InitializeComponent();
        }

        private void FormClientsInfo_Load(object sender, EventArgs e)
        {
            var sports = new SportsRepository();
            var sportsList = sports.GetAllSports();

            foreach (var sport in sportsList)
            {
                cbSelectSport.Items.Add(sport.Name);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            var tonyGym = new TonyGym();
            this.Hide();
            tonyGym.ShowDialog();
        }

        private void btnShowAllClients_Click(object sender, EventArgs e)
        {
            using var context = new SportClubDBContext();
            var clients = context.Clients.FromSqlRaw($"SELECT DISTINCT " +
                $"Clients.Id, CLients.Name, CLients.Surname, Clients.IdentificationNumber, Clients.Created " +
                $"FROM Clients " +
                $"LEFT JOIN TrainersClients ON Clients.Id = TrainersClients.ClientsId " +
                $"LEFT JOIN Trainers ON Trainers.Id = TrainersClients.TrainersId " +
                $"LEFT JOIN Sports ON Sports.Id = Trainers.SportId " +
                $"WHERE Sports.Name = '{cbSelectSport.Text}'")
                .ToList<Client>();

            var source = new BindingSource();
            source.DataSource = clients;
            dataGridView.DataSource = source;

        }  
    }
}
