using DBAtsiskaitymas;
using Microsoft.VisualBasic.Devices;
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
    public partial class FormNewClient : Form
    {
        public FormNewClient()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var newClient = new ClientService();
            newClient.RegisterNewClient(tbName.Text, tbSurname.Text, long.Parse(tbIdNumber.Text), DateTime.Parse(lbClock.Text));

            MessageBox.Show($"{tbName.Text} {tbSurname.Text} was added to Clients");
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var tonyGym = new TonyGym();
            this.Hide();
            tonyGym.ShowDialog();
        }
    }
}
