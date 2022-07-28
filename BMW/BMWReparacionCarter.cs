namespace Multiplataforma.BMW
{
    public class BMWReparacionCarter : ReparacionCarter
    {
        string label;

        public BMWReparacionCarter(string label)
        {
            this.label = label;
        }
        public override string Paint()
        {
            return "******** " + label + " ********";
        }
    }
}
