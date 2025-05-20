using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.FigurasGeometricas
{
    public class TrianguloEquilatero : IFormaGeometrica
    {
        public decimal Lado { get; }
        public string Clave => "triangulo";

        public TrianguloEquilatero(decimal lado) => Lado = lado;

        public decimal CalcularArea() => ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;
        public decimal CalcularPerimetro() => Lado * 3;
        public string ObtenerNombre(int cantidad, ITraductor traductor) => traductor.TraducirForma(Clave, cantidad);
    }
}
