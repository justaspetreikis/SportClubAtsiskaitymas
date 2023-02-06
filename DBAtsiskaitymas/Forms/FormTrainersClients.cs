using DBAtsiskaitymas;
using DBAtsiskaitymas.Models;
using Microsoft.EntityFrameworkCore;
using SportClub.Repositories;

namespace SportClub.Forms
{
    public partial class FormTrainersClients : Form
    {
        public FormTrainersClients()
        {
            InitializeComponent();
        }

        private void FormTrainersClients_Load(object sender, EventArgs e)
        {
            var trainers = new TrainersRepository();
            var trainersList = trainers.GetAllTrainers();

            foreach (var trainer in trainersList)
            {
                cbSelectTrainer.Items.Add($"{trainer.Name} {trainer.Surname}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var tonyGym = new TonyGym();
            this.Hide();
            tonyGym.ShowDialog();
        }

        private void btnShowClients_Click(object sender, EventArgs e)
        {
            var listNameSurname = cbSelectTrainer.Text.Split(' ').ToList();
            string name = listNameSurname[0];
            string surname = listNameSurname[1];

            using var context = new SportClubDBContext();
            var clients = context.Clients.FromSqlRaw($"SELECT " +
                $"Clients.Id, CLients.Name, CLients.Surname, Clients.IdentificationNumber, Clients.Created " +
                $"FROM Clients " +
                $"LEFT JOIN TrainersClients ON Clients.Id = TrainersClients.ClientsId " +
                $"LEFT JOIN Trainers ON Trainers.Id = TrainersClients.TrainersId " +
                $"WHERE Trainers.Name = '{name}' AND Trainers.Surname = '{surname}'")
                .ToList<Client>();

            var source = new BindingSource();
            source.DataSource = clients;
            dataGridView1.DataSource = source;
        }
    }
}
