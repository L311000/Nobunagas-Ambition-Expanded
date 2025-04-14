using NA_Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Components.Characters
{
    public class Mon : NA_Base
    {
        public string Filepath { get; set; }
        public string InternalName { get; set; }
        public Color Background { get; set; }
        public Color Color1 { get; set; }
        public Color Color2 { get; set; }
    }
}
