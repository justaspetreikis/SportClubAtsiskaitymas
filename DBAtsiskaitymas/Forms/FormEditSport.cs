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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SportClub.Forms
{
    public partial class FormEditSport : Form
    {
        public FormEditSport()
        {
            InitializeComponent();
        }

        private void FormEditSport_Load(object sender, EventArgs e)
        {
            var sports = new SportsRepository();
            var sportsList = sports.GetAllSports();

            foreach (var sport in sportsList)
            {
                cbSelectSport.Items.Add(sport.Name);
            }

            var trainers = new TrainersRepository();
            var trainersList = trainers.GetTrainersWithoutSport();

            foreach (var trainer in trainersList)
            {
                cb_SelectTrainer.Items.Add($"{trainer.Name} {trainer.Surname}");
            }

            var clients = new ClientsRepository();
            var clientsList = clients.GetAllClients();

            foreach (var client in clientsList)
            {
                clbClients.Items.Add(client.Name + " " + client.Surname);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var tonyGym = new TonyGym();
            this.Hide();
            tonyGym.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var trainerService = new TrainerService();
            var trainerRepository = new TrainersRepository();
            var clientRepository = new ClientsRepository();
            var trainersClientsService = new TrainersClientsService();

            trainerService.AddSportForTrainer(cb_SelectTrainer.Text, cbSelectSport.Text);

            foreach (object client in clbClients.CheckedItems)
            {
                string clientsNameAndSurname = client.ToString();
                trainersClientsService.AddClientToTrainer(trainerRepository.GetTrainersId(cb_SelectTrainer.Text),
                                                      clientRepository.GetClientId(clientsNameAndSurname));
            }

            MessageBox.Show($"Selected clients were added to {cbSelectSport.Text} trainings with trainer {cb_SelectTrainer.Text}");

        }
    }
}
