using NA_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Components.Localisations
{
    public class Localisation : NA_Base
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public int Priority { get; set; }
        public bool Custom { get; set; }

        public Localisation()
        {
        }

        public Localisation(string name, string text)
        {
            Name = name;
            Text = text;
            Priority = 0;
            Custom = false;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
