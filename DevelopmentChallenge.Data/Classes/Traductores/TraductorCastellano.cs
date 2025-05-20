using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class TraductorCastellano : ITraductor
    {
        private readonly Dictionary<string, string> _etiquetas = new Dictionary<string, string>
                {
                    {"area", "Area"},
                    {"perimetro", "Perímetro"},
                    {"formas", "Formas"},
                    {"total", "TOTAL"},
                    {"vacio", "Lista vacía de formas!"},
                    {"titulo", "Reporte de Formas"}
                };

        private readonly Dictionary<string, (string Singular, string Plural)> _formas = new Dictionary<string, (string, string)>
                {
                    {"cuadrado", ("Cuadrado", "Cuadrados")},
                    {"circulo", ("Círculo", "Círculos")},
                    {"triangulo", ("Triángulo", "Triángulos")},
                    {"rectangulo", ("Rectángulo", "Rectángulos")},
                    {"trapecio", ("Trapecio", "Trapecios")}
                };

        public string TraducirForma(string claveForma, int cantidad)
        {
            var forma = _formas[claveForma];
            return cantidad == 1 ? forma.Singular : forma.Plural;
        }

        public string TraducirEtiqueta(string claveEtiqueta)
        {
            return _etiquetas[claveEtiqueta];
        }
    }
}
