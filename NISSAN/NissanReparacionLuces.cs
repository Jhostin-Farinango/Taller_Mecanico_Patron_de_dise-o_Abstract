using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplataforma
{
    public class NissanReparacionLuces : ReparacionLuces
    {
        string text;
        public NissanReparacionLuces(string text)
        {
            this.text = text;
        }
        public override string Paint()
        {
            return "****** " + text + " ******";
        }
    }
}
