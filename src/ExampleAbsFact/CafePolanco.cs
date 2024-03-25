using System.Runtime.CompilerServices;

namespace ExampleAbsFact
{
    public class CafePolanco: Cafe 
    {
        public CafePolanco(string Medida, string Grano) : base (Medida, Grano)
        {

        }

        public override void Vender(decimal precio)
        {
            Console.WriteLine($"Cafe de {Grano} Tamaño: {Medida} Total: {precio} Sucursal polanco {DateTime.Now}");

        }


    }
    
}