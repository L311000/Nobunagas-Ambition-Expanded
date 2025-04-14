using NA_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Components.Localisations
{
    public class LocalisationCollection : NA_Base
    {
        public List<Localisation> Localisations { get; set; }
        public Game_Languages Language { get; set; }
    }
}
