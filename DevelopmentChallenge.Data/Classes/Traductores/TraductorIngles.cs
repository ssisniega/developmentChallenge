using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class TraductorIngles : ITraductor
    {
        private readonly Dictionary<string, string> _etiquetas = new Dictionary<string, string>
            {
                {"area", "Area"},
                {"perimetro", "Perimeter"},
                {"formas", "Shapes"},
                {"total", "TOTAL"},
                {"vacio", "Empty list of shapes!"},
                {"titulo", "Shapes report"}
            };

        private readonly Dictionary<string, (string Singular, string Plural)> _formas = new Dictionary<string, (string, string)>
            {
                {"cuadrado", ("Square", "Squares")},
                {"circulo", ("Circle", "Circles")},
                {"triangulo", ("Triangle", "Triangles")},
                {"rectangulo", ("Rectangle", "Rectangles")},
                {"trapecio", ("Trapezoid", "Trapezoids")}
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
