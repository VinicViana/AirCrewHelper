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
        public List<CheckListActions> ActionsToTake { get; set; }

        public CheckList()
        {
            Id = 0;
            ActionsToTake = new List<CheckListActions>();
        }
    }
}
