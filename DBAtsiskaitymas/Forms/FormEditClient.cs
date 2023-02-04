using DBAtsiskaitymas;
using SportClub.Repositories;
using SportClub.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportClub.Forms
{
    public partial class FormEditClient : Form
    {
        public FormEditClient()
        {
            InitializeComponent();
        }

        private void FormEditClient_Load(object sender, EventArgs e)
        {
            var clients = new ClientsRepository();
            var clientsList = clients.GetAllClients();

            foreach (var client in clientsList)
            {
                cbSelectClient.Items.Add($"{client.Name} {client.Surname}");
            }

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

        private void cbSelectTrainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var trainersRepository = new TrainersRepository();
            var sportsRepository = new SportsRepository();
 
            var trainer = trainersRepository.GetTrainerById(trainersRepository.GetTrainersId(cbSelectTrainer.Text));
            lbTrainersSport.Text = $"Sport: {sportsRepository.GetSportNameById(trainer.SportId)}";
        }

        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            var clientRepository = new ClientsRepository();
            var trainersClientsService = new TrainersClientsService();
            var trainerRepository = new TrainersRepository();

            trainersClientsService.AddClientToTrainer(trainerRepository.GetTrainersId(cbSelectTrainer.Text),
                                                      clientRepository.GetClientId(cbSelectClient.Text));

            MessageBox.Show($"{cbSelectClient.Text} was added to {lbTrainersSport.Text} trainings with trainer {cbSelectTrainer.Text}");
        }

    }
}
