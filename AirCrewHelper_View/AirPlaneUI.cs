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
    public partial class AirPlaneUI : Form
    {
        AirPlaneRepository airPlaneRepository = new AirPlaneRepository();

        public AirPlaneUI()
        {
            InitializeComponent();
        }

        private void AirPlaneUI_Load(object sender, EventArgs e)
        {
            refreshAirPlaneList();
        }

        private void btnNewAirPlane_Click(object sender, EventArgs e) => insertAirPlane();

        public void insertAirPlane()
        {
            AirPlane airPlane = new AirPlane();
            airPlane.Name = txtAirPlaneName.Text;

            airPlaneRepository.insert(airPlane);
            refreshAirPlaneList();
            ClearForm();
        }

        public void refreshAirPlaneList()
        {
            grdAirPlane.DataSource = airPlaneRepository.list().ToList();
        }

        public void ClearForm()
        {
            txtAirPlaneId.Text = string.Empty;
            txtAirPlaneName.Text = string.Empty;
        }
    }
}
