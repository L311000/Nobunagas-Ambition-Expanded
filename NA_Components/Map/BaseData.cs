using NA_Components;
using NA_Components.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Components.Map
{
    public class BaseData : NA_Base
    {
        public int Base_Level { get; set; }

        public int Base_HP { get; set; }
        public int Base_Tenshu_Level { get; set; }
        public int Base_Gate_Level { get; set; }
        public int Base_Walls_Level { get; set; }
        public int Base_Barbican_Level { get; set; }
        public int Base_Annex_Level { get; set; }
        public int Base_Tower_Level { get; set; }

        public NPCCharacter Lord { get; set; }
        public NPCCharacter Chamberlein { get; set; }
    }
}
