using SportClub.Forms;

namespace DBAtsiskaitymas
{
    public partial class TonyGym : Form
    {
        public TonyGym()
        {
            InitializeComponent();
        }

        private void btnClientsInfo_Click(object sender, EventArgs e)
        {
            var clientsInfo = new FormClientsInfo();
            this.Hide();
            clientsInfo.ShowDialog();
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            var newClient = new FormNewClient();
            this.Hide();
            newClient.ShowDialog();
        }

        private void btnNewTrainer_Click(object sender, EventArgs e)
        {
            var newTrainer = new FormNewTrainer();
            this.Hide();
            newTrainer.ShowDialog();
        }

        private void btnNewSport_Click(object sender, EventArgs e)
        {
            var newSport = new FormNewSport();
            this.Hide();
            newSport.ShowDialog();
        }

        private void btnEditSport_Click(object sender, EventArgs e)
        {
            var editSport = new FormEditSport();
            this.Hide();
            editSport.ShowDialog();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            var editClient = new FormEditClient();
            this.Hide();
            editClient.ShowDialog();
        }

        private void btnEditTrainer_Click(object sender, EventArgs e)
        {
            var editTrainer = new FormEditTrainer();
            this.Hide();
            editTrainer.ShowDialog();
        }

        private void btnTrainersInfo_Click(object sender, EventArgs e)
        {
            var trainersInfo = new FormTrainersInfo();
            this.Hide();
            trainersInfo.ShowDialog();
        }

        private void btnTrainersClients_Click(object sender, EventArgs e)
        {
            var trainersClients = new FormTrainersClients();
            this.Hide();
            trainersClients.ShowDialog();
        }

    }
}