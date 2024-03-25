namespace ExampleAbsFact
{
    public class PanaderiaVeracruz : FactoryPanaderia
    {
        public override Cafe CrearCafe()
        {
            var resutl = new CafeVeracruz("Alto", "Chiapas");
            resutl.Vender(56);
            return resutl;
        }

        public override Pan CrearPan()
        {
            var resutl = new PanVeracuz("Almendrado");
            resutl.DetallePan();
            return resutl;
        }
    }
}