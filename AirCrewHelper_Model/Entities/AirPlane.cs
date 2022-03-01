using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCrewHelper_Model.Entities
{
    public class AirPlane
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public AirPlane()
        {
            Id = 0;
            Nome = string.Empty;
        }
    }
}
