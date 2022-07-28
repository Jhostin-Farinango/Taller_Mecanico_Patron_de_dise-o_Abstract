namespace Multiplataforma.BMW
{
    public class BMWReparacionLuces : ReparacionLuces
    {
        string text;
        public BMWReparacionLuces(string text)
        {
            this.text = text;
        }
        public override string Paint()
        {
            return "****** " + text + " ******";

        }
    }
}
