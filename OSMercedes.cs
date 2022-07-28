
using Multiplataforma.MERCEDES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplataforma
{
    public class OSMercedes : IOS
    {
        public ReparacionLuces CreateButton(string text)
        {
            return new MercedesReparacionLuces(text);
        }

        public ReparacionFrenos CreateIcon(string type)
        {
            return new MercedesReparacionFrenos(type);
        }

        public ReparacionCarter CreateLabel(string label)
        {
            return new MercedesReparacionCarter(label);
        }
    }
}
