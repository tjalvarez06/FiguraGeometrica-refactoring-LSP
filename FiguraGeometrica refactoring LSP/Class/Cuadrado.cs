

namespace FiguraGeometrica_refactoring_LSP.Class
{
    public class Cuadrado : FiguraGeometrica
    {
        private double Lado { get; set; }
       
        public Cuadrado(double lado)
        {
            Lado = lado;
        }
        public override double CalcularArea()
        {
            return Lado * Lado;
        }
    }
}
