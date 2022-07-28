
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplataforma.MERCEDES
{
    public class MercedesReparacionCarter : ReparacionCarter
    {
        string label;
        public MercedesReparacionCarter(string label)
        {
            this.label = label;
        }
        public override string Paint()
        {
            return "******** " + label + " ********";
        }
    }
}
