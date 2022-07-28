using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplataforma.NISSAN
{
    public class NissanReparacionCarter : ReparacionCarter
    {
        string label;
        public NissanReparacionCarter(string label)
        {
            this.label = label;
        }
        public override string Paint()
        {
            return "******** " + label + " ********";
        }
    }
}
