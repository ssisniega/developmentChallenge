using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.FigurasGeometricas
{
    public class Rectangulo : IFormaGeometrica
    {
        public decimal Base { get; }
        public decimal Altura { get; }
        public string Clave => "rectangulo";

        public Rectangulo(decimal @base, decimal altura)
        {
            Base = @base;
            Altura = altura;
        }

        public decimal CalcularArea() => Base * Altura;
        public decimal CalcularPerimetro() => 2 * (Base + Altura);
        public string ObtenerNombre(int cantidad, ITraductor traductor) => traductor.TraducirForma(Clave, cantidad);
    }
}
