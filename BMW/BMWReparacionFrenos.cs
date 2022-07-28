namespace Multiplataforma.BMW
{
    public class BMWReparacionFrenos : ReparacionFrenos
    {
        string type;
        public BMWReparacionFrenos(string type)
        {
            this.type = type;
        }
        public override string Paint()
        {
            string resultado = "";

            switch (type)
            {
                case "Alerta":
                    resultado = " \n Marca: BMW \n Cantidad: 1 | Reparacion Luces: $ 40 | \n Cantidad: 1 | Reparacion Frenos: $ 10 | \n Cantidad: 1 | Reparacion Carter: $ 20 | \n SubTotal: $ 70 \n Total + 12%: $ 78.40";
                    break;

                case "Peligro":
                    resultado = "";
                    break;
            }
            return resultado;
        }
    }
}
