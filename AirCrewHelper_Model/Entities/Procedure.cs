using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCrewHelper_Model.Entities
{
    public class Procedure
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CheckListId { get; set; }
        public CheckList CheckListToUse { get; set; }

        public Procedure()
        {
            Id = 0;
            Description = string.Empty;
            CheckListId = 0;
            CheckListToUse = new CheckList();
        }

    }
}
