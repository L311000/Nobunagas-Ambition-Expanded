using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Components.Graphical
{
    public abstract class MonTemplate
    {
        public string EmblemName { get; set; }
        public List<Size> Color1Pixels { get; set; } = new();
        public List<Size> Color2Pixels { get; set; } = new();
        public List<Size> Color3Pixels { get; set; } = new();
    }
}
