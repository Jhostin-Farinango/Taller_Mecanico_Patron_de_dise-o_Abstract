namespace Multiplataforma
{
    public class Aplication
    {
        public IOS plataforma; // asosiacion
        List<GUIObject> GUI;

        public Aplication(IOS plataforma) //
        {
            this.plataforma = plataforma;   
            GUI = new List<GUIObject>();
        }

        public void CrearIU()
        {
            ReparacionCarter titulo = plataforma.CreateLabel("Factura Taller Jhostin");
            ReparacionCarter mensaje = plataforma.CreateLabel("Su auto en las mejores manos del Pais!");
            ReparacionFrenos iconoAlerta = plataforma.CreateIcon("Alerta");
            ReparacionLuces buttonOk = plataforma.CreateButton("OK");
            ReparacionLuces buttonCancelar = plataforma.CreateButton("cancelar");

            GUI.Add(titulo);
            GUI.Add(mensaje);
            GUI.Add(iconoAlerta);
            GUI.Add(buttonOk);
            GUI.Add(buttonCancelar);
        }

        public void Paint()
        {
            string pantalla="";
            foreach (var objeto in GUI)
            {
                pantalla += objeto.Paint() + "\n";
            }
            Console.WriteLine(pantalla);
        }
    }
}
