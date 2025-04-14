using NA_Components;
using NA_Components.Factions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Components.Relations
{
    public class FactionDiplomaticRelationScore : NA_Base
    {
        public Faction Faction1 { get; set; }
        public Faction Faction2 { get; set; }
        public int Score { get; set; }
    }
}
