using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.FigurasGeometricas
{
    public class Circulo : IFormaGeometrica
    {
        public decimal Diametro { get; }
        public string Clave => "circulo";

        public Circulo(decimal diametro) => Diametro = diametro;

        public decimal CalcularArea() => (decimal)Math.PI * (Diametro / 2) * (Diametro / 2);
        public decimal CalcularPerimetro() => (decimal)Math.PI * Diametro;
        public string ObtenerNombre(int cantidad, ITraductor traductor) => traductor.TraducirForma(Clave, cantidad);
    }

}
