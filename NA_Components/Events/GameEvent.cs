using NA_Components;
using NA_Components.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Components.Events
{
    public class GameEvent : NA_Base
    {
        public List<GameCondition> Conditions { get; set; }
        public List<GameResult> Results { get; set; }
    }
}
