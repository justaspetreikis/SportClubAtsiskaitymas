using DBAtsiskaitymas;
using SportClub.Repositories;
using SportClub.Services;

namespace SportClub.Forms
{
    public partial class FormNewTrainer : Form
    {
        public FormNewTrainer()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var sport = new SportsRepository();
            var newTrainer = new TrainerService();

            newTrainer.RegisterNewTrainer(tbName.Text, tbSurname.Text, sport.SportsIdByName(cbSports.Text));

            MessageBox.Show($"{tbName.Text} {tbSurname.Text} was added to Trainers");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var tonyGym = new TonyGym();
            this.Hide();
            tonyGym.ShowDialog();
        }

        private void FormNewTrainer_Load(object sender, EventArgs e)
        {
            var sports = new SportsRepository();
            var sportsList = sports.GetAllSports();

            foreach (var sport in sportsList)
            {
                cbSports.Items.Add(sport.Name);
            }
        }
    }
}
