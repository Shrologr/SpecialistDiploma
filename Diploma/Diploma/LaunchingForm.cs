using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma
{
    public partial class LaunchingForm : Form
    {
        public LaunchingForm()
        {
            InitializeComponent();
        }

        private void AdvectionWindowCallButton_Click(object sender, EventArgs e)
        {
            new AdvectionForm().Show();
        }

        private void PuankareWindowCallButton_Click(object sender, EventArgs e)
        {
            new PoincareForm().Show();
        }

        private void TrajectoryWindowCallButton_Click(object sender, EventArgs e)
        {
            new TrajectoryForm().Show();
        }

        private void StatisticsWindowCallButton_Click(object sender, EventArgs e)
        {
            new StatisticsForm().Show();
        }
    }
}
