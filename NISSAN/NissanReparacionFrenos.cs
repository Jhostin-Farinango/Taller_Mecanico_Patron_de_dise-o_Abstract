using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplataforma
{
    public class NissanReparacionFrenos : ReparacionFrenos
    {
        string type;
        public NissanReparacionFrenos(string type)
        {
            this.type = type;
        }
        public override string Paint()
        {
            string resultado = "";
            switch (type)
            {
                case "Alerta":
                    resultado = " \n Marca: Nissan \n Cantidad: 1 | Reparacion Luces: $ 40 | \n Cantidad: 1 | Reparacion Frenos: $ 10 | \n Cantidad: 1 | Reparacion Carter: $ 20 | \n SubTotal: $ 70 \n Total + 12%: $ 78.40";
                    break;

                case "Peligro":
                    resultado = "Peligro";
                    break;
            }
            return resultado;
        }
    }
}
