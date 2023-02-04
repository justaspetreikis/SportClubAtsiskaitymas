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
    public partial class FormNewSport : Form
    {
        public FormNewSport()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var newSport = new SportService();
            newSport.RegisterNewSport(new SportsRepository().NextSportId(), tbName.Text);

            DialogResult dialogResult = MessageBox.Show("Would you like to add trainer or clients?", "New Sport", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var editSport = new FormEditSport();
                this.Hide();
                editSport.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show($"{tbName.Text} was added to Sports");
            }
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var tonyGym = new TonyGym();
            this.Hide();
            tonyGym.ShowDialog();
        }

        private void FormNewSport_Load(object sender, EventArgs e)
        {
            tbId.Text = new SportsRepository().NextSportId().ToString();
        }
    }
}
