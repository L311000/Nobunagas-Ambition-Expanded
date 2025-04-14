using NA_Components;
using NA_Components.Localisations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Components.Characters
{
    public class Dynasty : NA_Base
    {
        public Localisation Name { get; set; }
        public long Prestige { get; set; }
        public FamilySocietyStatus Status { get; set; }
        public List<NPCCharacter> Members { get; set; }
        public Mon Emblem { get; set; }
    }
}
