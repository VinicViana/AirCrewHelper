using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCrewHelper_Model.Entities
{
    public class Pilot
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int AirCrewId { get; set; }
        public AirCrew AirCrew { get; set; }

        public Pilot()
        {
            Id = 0;
            Nome = string.Empty;
            AirCrewId = 0;
            AirCrew = new AirCrew();
        }
    }
}
