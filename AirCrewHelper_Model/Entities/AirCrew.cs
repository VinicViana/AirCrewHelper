using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCrewHelper_Model.Entities
{
    public class  AirCrew
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public AirCrew()
        {
            Id = 0;
            Nome = string.Empty;
        }
    }
}
