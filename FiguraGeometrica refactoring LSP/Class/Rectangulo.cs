

namespace FiguraGeometrica_refactoring_LSP.Class
{
    public class Rectangulo : FiguraGeometrica
    {
        private double Base {  get; set; }
        private double Altura { get; set; }

        public Rectangulo(double baseFigura, double altura) 
        {
            Base = baseFigura;
            Altura = altura;
        }
        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
