using AirCrewHelper_ManagerView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirCrewHelper_View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void procedureToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pilotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PilotUI pilotUI = new PilotUI();
            pilotUI.Show();
        }

        private void airplaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AirPlaneUI airPlaneUI = new AirPlaneUI();
            airPlaneUI.Show();
        }
    }
}
