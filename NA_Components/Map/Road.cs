using NA_Components;
using NA_Components.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Components.Map
{
    public class Road : NA_Base
    {
        public int Level { get; set; } = 1;
        public List<Location> LocationsConnected { get; set; }
    }
}
