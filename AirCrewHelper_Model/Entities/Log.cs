using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCrewHelper_Model.Entities
{
    public class Log
    {
        public int Id { get; set; }
        public int PilotId { get; set; }
        public int ProcedureId { get; set; }
        public DateTime InstantRecord { get; set; }
        public string Description { get; set; }
        public Pilot Pilot { get; set; }
        public Procedure Procedure { get; set; }


        public Log()
        {
            Id = 0;
            PilotId = 0;
            ProcedureId = 0;
            InstantRecord = new DateTime(1900/01/01);
            Description = string.Empty;
            Pilot = new Pilot();
            Procedure = new Procedure();
        }
    }
}
