using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCrewHelper_Model.Entities
{
    public class CheckListActions
    {
        public int Id { get; set; }
        public int CheckListId { get; set; }
        public int ActionId { get; set; }
        public CheckList CheckList { get; set; }
        public Action Action { get; set; }
        
        public CheckListActions()
        {
            Id = 0;
            CheckListId = 0;
            ActionId = 0;
            CheckList = new CheckList();
            Action = new Action();
        }
    }
}
