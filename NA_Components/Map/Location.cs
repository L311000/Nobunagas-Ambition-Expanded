using NA_Components;
using NA_Components.Localisations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Components.Map
{
    public class Location : NA_Base
    {
        public string Name { get; set; }
        public HoldingStatus LocationType { get; set; }
        public List<Road> RoadsConnected { get; set; } = new();
        public bool IsWater { get; set; }

        public int Population { get; set; }
        public int Soldiers { get; set; }
        public int Morale { get; set; }
        public int Proficiency { get; set; }
        public BaseData Base { get; set; }
    }
}
