using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.FigurasGeometricas
{
    public class Cuadrado : IFormaGeometrica
    {
        public decimal Lado { get; }
        public string Clave => "cuadrado";

        public Cuadrado(decimal lado) => Lado = lado;

        public decimal CalcularArea() => Lado * Lado;
        public decimal CalcularPerimetro() => Lado * 4;
        public string ObtenerNombre(int cantidad, ITraductor traductor) => traductor.TraducirForma(Clave, cantidad);
    }
}