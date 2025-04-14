using NA_Components;
using NA_Components.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Components.Relations
{
    public class NPCCharacterRelation : NA_Base
    {
        public NPCCharacter Character1 { get; set; }
        public NPCCharacter Character2 { get; set; }
        public int Friendship_Score { get; set; }
    }
}
