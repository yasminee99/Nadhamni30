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
    public partial class Parents : Form
    {
        public Parents()
        {
            InitializeComponent();
        }

        private void btnSaveParents_Click(object sender, EventArgs e)
        {
            if (PersonalInformation.Worker)
            {
                Job j = new Job();
                j.Show();
                this.Hide();
            }
            if (PersonalInformation.Student)
            {
                Studies st = new Studies();
                st.Show();
                this.Hide();
            }
            if (PersonalInformation.unemployed)
            {
                Dashboard d = new Dashboard();
                d.Show();
                this.Hide();
            }
        }
    }
}
