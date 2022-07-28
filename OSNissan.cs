
using Multiplataforma.NISSAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplataforma
{
    public class OSNissan : IOS
    {
        public ReparacionLuces CreateButton(string text)
        {
            return new NissanReparacionLuces(text);
        }

        public ReparacionFrenos CreateIcon(string type)
        {
            return new NissanReparacionFrenos(type);
        }

        public ReparacionCarter CreateLabel(string label)
        {
            return new NissanReparacionCarter(label);
        }
    }
}
