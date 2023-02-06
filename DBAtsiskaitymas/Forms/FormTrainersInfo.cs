using DBAtsiskaitymas;
using SportClub.Repositories;
using System.Data;

namespace SportClub.Forms
{
    public partial class FormTrainersInfo : Form
    {
        public FormTrainersInfo()
        {
            InitializeComponent();
        }

        private void btnShowAllTrainers_Click(object sender, EventArgs e)
        {
            var sportId = new SportsRepository().SportsIdByName(cbSelectSport.Text);
            var trainers = new TrainersRepository().GetAllTrainers();
            var sportTrainers = trainers.Where(x => x.SportId == (new SportsRepository().SportsIdByName(cbSelectSport.Text)));

            var source = new BindingSource();
            source.DataSource = sportTrainers;
            dataGridView.DataSource = source;
        }

        private void FormTrainersInfo_Load(object sender, EventArgs e)
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
    }
}
