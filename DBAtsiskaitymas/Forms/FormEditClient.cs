using DBAtsiskaitymas;
using SportClub.Repositories;
using SportClub.Services;

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

            var existingTrainersClients = new TrainerClientRepository().GetAllTrainersClients()
                .FirstOrDefault(x => x.TrainersId == trainerRepository.GetTrainersId(cbSelectTrainer.Text)
                && x.ClientsId == clientRepository.GetClientId(cbSelectClient.Text));

            if (existingTrainersClients != null)
            {
                MessageBox.Show("Client already training with this Trainer");
                return;
            }

            trainersClientsService.AddClientToTrainer(trainerRepository.GetTrainersId(cbSelectTrainer.Text),
                                                      clientRepository.GetClientId(cbSelectClient.Text));

            MessageBox.Show($"{cbSelectClient.Text} was added to {lbTrainersSport.Text} trainings with trainer {cbSelectTrainer.Text}");
        }

    }
}
