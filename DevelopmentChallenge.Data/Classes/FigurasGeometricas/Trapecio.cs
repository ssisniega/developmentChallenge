using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.FigurasGeometricas
{
    public class Trapecio : IFormaGeometrica
    {
        public decimal BaseMayor { get; }
        public decimal BaseMenor { get; }
        public decimal Altura { get; }
        public decimal Lado1 { get; }
        public decimal Lado2 { get; }
        public string Clave => "trapecio";

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal lado1, decimal lado2)
        {
            BaseMayor = baseMayor;
            BaseMenor = baseMenor;
            Altura = altura;
            Lado1 = lado1;
            Lado2 = lado2;
        }

        public decimal CalcularArea() => ((BaseMayor + BaseMenor) / 2) * Altura;
        public decimal CalcularPerimetro() => BaseMayor + BaseMenor + Lado1 + Lado2;
        public string ObtenerNombre(int cantidad, ITraductor traductor) => traductor.TraducirForma(Clave, cantidad);
    }
}
