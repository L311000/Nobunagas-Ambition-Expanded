using NA_Components.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Components
{
    public static class GameSession
    {
        public static DateOnly CurrentDate { get; set; }
        public static NPCCharacter Shogun { get; set; }
        public static NPCCharacter Emperor { get; set; }
    }
}
