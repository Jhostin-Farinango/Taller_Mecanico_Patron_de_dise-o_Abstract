using System;

namespace Multiplataforma
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aplication app = new Aplication(new OSMercedes());

            app.CrearIU();
            app.Paint();
        }
    }
}