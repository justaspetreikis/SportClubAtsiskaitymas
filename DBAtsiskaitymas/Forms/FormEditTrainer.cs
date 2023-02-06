using DBAtsiskaitymas;
using SportClub.Repositories;
using SportClub.Services;

namespace SportClub.Forms
{
    public partial class FormEditTrainer : Form
    {
        public FormEditTrainer()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var tonyGym = new TonyGym();
            this.Hide();
            tonyGym.ShowDialog();
        }

        private void FormEditTrainer_Load(object sender, EventArgs e)
        {
            var trainers = new TrainersRepository();
            var trainersList = trainers.GetAllTrainers();

            foreach (var trainer in trainersList)
            {
                cbSelectTrainer.Items.Add($"{trainer.Name} {trainer.Surname}");
            }

            var sports = new SportsRepository();
            var sportsList = sports.GetAllSports();

            foreach (var sport in sportsList)
            {
                cbSelectSport.Items.Add(sport.Name);
            }

            var clients = new ClientsRepository();
            var clientsList = clients.GetAllClients();

            foreach (var client in clientsList)
            {
                clbClients.Items.Add(client.Name +" "+client.Surname);
            }

        }

        private void cbSelectTrainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var trainersRepository = new TrainersRepository();
            var sportsRepository = new SportsRepository();

            var trainer = trainersRepository.GetTrainerById(trainersRepository.GetTrainersId(cbSelectTrainer.Text));
            lbTrainersSport.Text = $"Sport: {sportsRepository.GetSportNameById(trainer.SportId)}";
        }

        private void btnChangeAndAdd_Click(object sender, EventArgs e)
        {
            var trainersRepository = new TrainersRepository();
            var trainersClientsService = new TrainersClientsService();
            var clientRepository = new ClientsRepository();
            var trainerService = new TrainerService();

            trainerService.DeleteTrainersClients(cbSelectTrainer.Text);
            trainerService.AddSportForTrainer(cbSelectTrainer.Text, cbSelectSport.Text);

            foreach (object client in clbClients.CheckedItems)
            {
                string clientsNameAndSurname = client.ToString();
                trainersClientsService.AddClientToTrainer(trainersRepository.GetTrainersId(cbSelectTrainer.Text),
                                                      clientRepository.GetClientId(clientsNameAndSurname));
            }

            MessageBox.Show($"Trainers: {cbSelectTrainer.Text} sport was changed to {cbSelectSport.Text} with selected clients");
        }

    }
}
