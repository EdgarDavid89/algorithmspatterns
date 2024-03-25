
namespace ExampleAbsFact
{
    public class PanaderiaPolanco : FactoryPanaderia
    {
        public override Cafe CrearCafe()
        {
            var result = new CafePolanco("Grande", "Cubano");
            result.Vender(156);
            return result;
        }

        public override Pan CrearPan()
        {

            var resutl = new PanPolanco("Blanco");
            resutl.DetallePan();

            return resutl;
        }
    }
}

