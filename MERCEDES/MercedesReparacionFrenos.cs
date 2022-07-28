
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplataforma.MERCEDES
{
    public class MercedesReparacionFrenos : ReparacionFrenos
    {
        string type;
        public MercedesReparacionFrenos(string type)
        {
            this.type = type;
        }
        public override string Paint()
        {
            string resultado = "";
            switch (type)
            {
                case "Alerta":
                    resultado = " \n Marca: Mercedes \n Cantidad: 1 | Reparacion Luces: $ 80 | \n Cantidad: 1 | Reparacion Frenos: $ 120 | \n Cantidad: 1 | Reparacion Carter: $ 200 | \n SubTotal: $ 400 \n Total + 12%: $ 448";
                    break;

                case "Peligro":
                    resultado = "Peligro";
                    break;
            }
            return resultado;
        }
    }
}
