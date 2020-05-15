using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetNadhamni
{
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dsh2 = new Dashboard();
            this.Hide();
            dsh2.Show();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Profile pf2 = new Profile();
            this.Hide();
            pf2.Show();
        }

        private void btn_statistics_Click(object sender, EventArgs e)
        {
            Statistics stc2 = new Statistics();
            this.Hide();
            stc2.Show();
        }

        private void btn_parameters_Click(object sender, EventArgs e)
        {
            Settings st2 = new Settings();
            this.Hide();
            st2.Show();
        }

        private void ExitDashboard_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
