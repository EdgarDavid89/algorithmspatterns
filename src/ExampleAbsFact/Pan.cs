using System.Xml.Schema;

namespace ExampleAbsFact 
{
    public abstract class Pan 
    {
        public string TipoPan { get; set; } = "Dulce";

        public Pan(string tipo)
        {
            TipoPan = tipo;
        }
    }
}