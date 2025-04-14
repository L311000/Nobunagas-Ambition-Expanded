using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Components.Characters
{
    public class NPCCharacterName
    {
        public string Prefix { get; set; }
        public string PersonalName { get; set; }

        public override string ToString()
        {
            return Prefix + PersonalName;
        }
    }
}
