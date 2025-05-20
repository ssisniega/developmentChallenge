using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public static class ReporteFormasHelper
    {
        public static string Imprimir(List<IFormaGeometrica> formas, ITraductor traductor)
        {
            if (formas == null || !formas.Any())
                return $"<h1>{traductor.TraducirEtiqueta("vacio")}</h1>";

            var sb = new StringBuilder();
            sb.Append($"<h1>{traductor.TraducirEtiqueta("titulo")}</h1>");

            var resumen = formas
                .GroupBy(f => f.Clave)
                .Select(g => new
                {
                    Clave = g.Key,
                    Cantidad = g.Count(),
                    Area = g.Sum(f => f.CalcularArea()),
                    Perimetro = g.Sum(f => f.CalcularPerimetro()),
                    Nombre = g.First().ObtenerNombre(g.Count(), traductor)
                });

            foreach (var item in resumen)
            {
                sb.Append($"{item.Cantidad} {item.Nombre} | {traductor.TraducirEtiqueta("area")} {item.Area:N2} | {traductor.TraducirEtiqueta("perimetro")} {item.Perimetro:N2} <br/>\n");
            }

            var totalArea = formas.Sum(f => f.CalcularArea());
            var totalPerimetro = formas.Sum(f => f.CalcularPerimetro());

            sb.Append($"{traductor.TraducirEtiqueta("total")}:<br/>\n");
            sb.Append($"{formas.Count} {traductor.TraducirEtiqueta("formas")} {traductor.TraducirEtiqueta("perimetro")} {totalPerimetro:N2} {traductor.TraducirEtiqueta("area")} {totalArea:N2}");

            return sb.ToString().Replace(",", ".");
        }

    }
}
