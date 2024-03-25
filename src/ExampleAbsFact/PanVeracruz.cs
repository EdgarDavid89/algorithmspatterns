namespace ExampleAbsFact 
{
    public class PanVeracuz : Pan
    {
        public PanVeracuz(string Tipo) : base (Tipo)
        {

        }

        public void DetallePan()
        {
            Console.WriteLine($"Tpo {TipoPan} horneado en sucursal Veracruz");
        }

    }
}