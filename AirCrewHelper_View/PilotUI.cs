using AirCrewHelper_Model.Entities;
using AirCrewHelper_Model.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirCrewHelper_ManagerView
{
    public partial class PilotUI : Form
    {
        public PilotUI()
        {
            InitializeComponent();
        }

        private void lblPilotName_Click(object sender, EventArgs e)
        {

        }

        private void PilotUI_Load(object sender, EventArgs e)
        {
            PilotRepository pilotRepository = new PilotRepository();
            gridPilot.DataSource = pilotRepository.list().ToList();
        }

        private void txtNewPilot_Click(object sender, EventArgs e)
        {
            PilotRepository pilotRepository = new PilotRepository();
            Pilot pilot = new Pilot();

            pilot.Nome = txtPilotName.Text;
            pilot.AirCrewId = 1;

            pilotRepository.insert(pilot);
            refreshPilotGridView();
            clearForm();
        }

        public void refreshPilotGridView()
        {
            PilotRepository pilotRepository = new PilotRepository();
            gridPilot.DataSource = pilotRepository.list().ToList();
        }

        public void clearForm()
        {
            txtPilotName.Text = string.Empty;
        }
    }
}
