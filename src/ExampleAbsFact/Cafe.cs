using System.Runtime.CompilerServices;

namespace ExampleAbsFact
{
    public abstract class Cafe
    {
        public string Medida { get; set;} =  "Mediano";
        public string Grano {get; set;} = "Mexicano";

        public Cafe(string medida, string grano)
        {
            Medida = medida;
            Grano = grano;
        }

        public abstract void Vender(decimal precio);


     }
}