namespace ExampleAbsFact
{
    public class CafeVeracruz : Cafe
    {
        public CafeVeracruz(string Medida, string Grano) : base (Medida, Grano)
        {

        }

        public override void Vender(decimal precio)
        {
            Console.WriteLine($"Cafe de {Grano} Tamaño: {Medida} Total: {precio} Sucursal Veracruz {DateTime.Now}");

        }

    }
}