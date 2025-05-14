using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Components.Graphical
{
    public class Mon : NA_Base
    {
        public Color Background { get; set; }
        public Color Color1 { get; set; }
        public Color Color2 { get; set; }
        public Color Color3 { get; set; }
        public MonTemplate Template { get; set; }

        public Mon(MonTemplate template)
        {
            Template = template;
        }
    }
}
