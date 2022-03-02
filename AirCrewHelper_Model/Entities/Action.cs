using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCrewHelper_Model.Entities
{
    public class Action
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Action()
        {
            Id = 0;
            Name = string.Empty;
        }
    }
}