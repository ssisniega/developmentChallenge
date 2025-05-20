using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class TraductorItaliano : ITraductor
    {
        private readonly Dictionary<string, string> _etiquetas = new Dictionary<string, string>
            {
                {"area", "Area"},
                {"perimetro", "Perimetro"},
                {"formas", "Forme"},
                {"total", "TOTALE"},
                {"vacio", "Lista vuota di forme!"},
                {"titulo", "Rapporto di forme"}
            };

        private readonly Dictionary<string, (string Singular, string Plural)> _formas = new Dictionary<string, (string, string)>
            {
                {"cuadrado", ("Quadrato", "Quadrati")},
                {"circulo", ("Cerchio", "Cerchi")},
                {"triangulo", ("Triangolo", "Triangoli")},
                {"rectangulo", ("Rettangolo", "Rettangoli")},
                {"trapecio", ("Trapezio", "Trapezi")}
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
