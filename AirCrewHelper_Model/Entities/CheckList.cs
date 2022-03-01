using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCrewHelper_Model.Entities
{
    public class CheckList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CheckListActions> ActionsToTake { get; set; }

        public CheckList()
        {
            Id = 0;
            Name = string.Empty;
            ActionsToTake = new List<CheckListActions>();
        }
    }
}
