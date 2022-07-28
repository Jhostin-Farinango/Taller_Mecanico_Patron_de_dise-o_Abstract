
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplataforma
{
    public interface IOS
    {
        public ReparacionLuces CreateButton(string text);

        public ReparacionCarter CreateLabel(string label);
        public ReparacionFrenos CreateIcon(string type);
    }
}
