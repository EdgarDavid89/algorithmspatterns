namespace ExampleAbsFact 
{
    public class PanPolanco : Pan
    {
        public PanPolanco(string Tipo) : base (Tipo)
        {

        }

        public void DetallePan()
        {
            Console.WriteLine($"Tpo {TipoPan} horneado en sucursal Polanco");
        }

    }
}