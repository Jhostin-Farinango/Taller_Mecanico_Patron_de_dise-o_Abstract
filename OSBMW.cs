using Multiplataforma.BMW;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplataforma
{
    public class OSBMW : IOS
    {
        public ReparacionLuces CreateButton(string text)
        {
            return new BMWReparacionLuces(text);
        }

        public ReparacionFrenos CreateIcon(string type)
        {
            return new BMWReparacionFrenos(type);
        }

        public ReparacionCarter CreateLabel(string label)
        {
            return new BMWReparacionCarter(label);
        }
    }
}
