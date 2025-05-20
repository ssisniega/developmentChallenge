using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.FigurasGeometricas;
using DevelopmentChallenge.Data.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;

namespace DevelopmentChallenge.Tests.Refactor
{
    [TestFixture]
    public class ReporteFormasHelperTests
    {
        private readonly ITraductor castellano = new TraductorCastellano();
        private readonly ITraductor italiano = new TraductorItaliano();
        private readonly ITraductor ingles = new TraductorIngles();


        #region Test's para validar Listas Vacias en diferentes idiomas
        [Test]
        public void TestResumenListaVaciaFormasEnCastellano()
        {
            var resultado = ReporteFormasHelper.Imprimir(new List<IFormaGeometrica>(), castellano);
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", resultado.Trim());
        }

        [Test]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            var resultado = ReporteFormasHelper.Imprimir(new List<IFormaGeometrica>(), italiano);
            Assert.AreEqual("<h1>Lista vuota di forme!</h1>", resultado.Trim());
        }

        [Test]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            var resultado = ReporteFormasHelper.Imprimir(new List<IFormaGeometrica>(), ingles);
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", resultado.Trim());
        }
        #endregion

        #region Test's para validar la existencia de una figura geométrica, en diferentes idiomas

        [Test]
        public void TestResumenListaConUnCuadradoCastellano()
        {
            var formas = new List<IFormaGeometrica> { new Cuadrado(5) };
            var resultado = ReporteFormasHelper.Imprimir(formas, castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Cuadrado | Area 25.00 | Perímetro 20.00 <br/>\nTOTAL:<br/>\n1 Formas Perímetro 20.00 Area 25.00",
                resultado.Trim());
        }

        [Test]
        public void TestResumenListaConUnCuadradoItaliano()
        {
            var formas = new List<IFormaGeometrica> { new Cuadrado(30) };
            var resultado = ReporteFormasHelper.Imprimir(formas, italiano);

            Assert.AreEqual(
                "<h1>Rapporto di forme</h1>1 Quadrato | Area 900.00 | Perimetro 120.00 <br/>\nTOTALE:<br/>\n1 Forme Perimetro 120.00 Area 900.00",
                resultado.Trim());
        }

        [Test]
        public void TestResumenListaConUnCuadradoIngles()
        {
            var formas = new List<IFormaGeometrica> { new Cuadrado(30) };
            var resultado = ReporteFormasHelper.Imprimir(formas, ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>1 Square | Area 900.00 | Perimeter 120.00 <br/>\nTOTAL:<br/>\n1 Shapes Perimeter 120.00 Area 900.00",
                resultado.Trim());
        }

        [Test]
        public void TestResumenListaConUnCirculoCastellano()
        {
            var formas = new List<IFormaGeometrica> { new Circulo(10) };
            var resultado = ReporteFormasHelper.Imprimir(formas, castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Círculo | Area 78.54 | Perímetro 31.42 <br/>\nTOTAL:<br/>\n1 Formas Perímetro 31.42 Area 78.54",
                resultado.Trim());
        }

        [Test]
        public void TestResumenListaConUnTrianguloCastellano()
        {
            var formas = new List<IFormaGeometrica> { new TrianguloEquilatero(6) };
            var resultado = ReporteFormasHelper.Imprimir(formas, castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Triángulo | Area 15.59 | Perímetro 18.00 <br/>\nTOTAL:<br/>\n1 Formas Perímetro 18.00 Area 15.59",
                resultado.Trim());
        }

        [Test]
        public void TestResumenListaConUnRectanguloCastellano()
        {
            var formas = new List<IFormaGeometrica> { new Rectangulo(3, 7) };
            var resultado = ReporteFormasHelper.Imprimir(formas, castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Rectángulo | Area 21.00 | Perímetro 20.00 <br/>\nTOTAL:<br/>\n1 Formas Perímetro 20.00 Area 21.00",
                resultado.Trim());
        }

        [Test]
        public void TestResumenListaConUnTrapecioCastellano()
        {
            var formas = new List<IFormaGeometrica> { new Trapecio(10, 6, 4, 3, 3) };
            var resultado = ReporteFormasHelper.Imprimir(formas, castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Trapecio | Area 32.00 | Perímetro 22.00 <br/>\nTOTAL:<br/>\n1 Formas Perímetro 22.00 Area 32.00",
                resultado.Trim());
        }

        #endregion

        #region Test's para validar existencia de más de una figura geométrica, en diferentes idiomas
        [Test]
        public void TestResumenListaConMasCuadradosCastellano()
        {
            var formas = new List<IFormaGeometrica>
                {
                    new Cuadrado(4),
                    new Cuadrado(6),
                    new Cuadrado(2)
                };

            var resultado = ReporteFormasHelper.Imprimir(formas, castellano);

            Assert.IsTrue(resultado.Contains("3 Cuadrados"));
            Assert.IsTrue(resultado.Contains("Area 56.00"));
            Assert.IsTrue(resultado.Contains("Perímetro 48.00"));
        }

        [Test]
        public void TestResumenListaConMasCuadradosItaliano()
        {
            var formas = new List<IFormaGeometrica>
                {
                    new Cuadrado(3),
                    new Cuadrado(4),
                    new Cuadrado(5)
                };

            var resultado = ReporteFormasHelper.Imprimir(formas, italiano);

            Assert.IsTrue(resultado.Contains("3 Quadrati"));
            Assert.IsTrue(resultado.Contains("Area 50.00"));
            Assert.IsTrue(resultado.Contains("Perimetro 48.00"));
        }

        [Test]
        public void TestResumenListaConMasCuadradosIngles()
        {
            var formas = new List<IFormaGeometrica>
                {
                    new Cuadrado(6),
                    new Cuadrado(2),
                    new Cuadrado(1)
                };

            var resultado = ReporteFormasHelper.Imprimir(formas, ingles);

            Assert.IsTrue(resultado.Contains("3 Squares"));
            Assert.IsTrue(resultado.Contains("Area 41.00"));
            Assert.IsTrue(resultado.Contains("Perimeter 36.00"));
        }

        [Test]
        public void TestResumenListaConMasCirculosCastellano()
        {
            var formas = new List<IFormaGeometrica>
                {
                    new Circulo(3),
                    new Circulo(4),
                    new Circulo(2)
                };

            var resultado = ReporteFormasHelper.Imprimir(formas, castellano);

            Assert.IsTrue(resultado.Contains("3 Círculos"));
            Assert.IsTrue(resultado.Contains("Area 22.78"));
            Assert.IsTrue(resultado.Contains("Perímetro 28.27"));
        }

        [Test]
        public void TestResumenListaConMasCirculosItaliano()
        {
            var formas = new List<IFormaGeometrica>
                {
                    new Circulo(6),
                    new Circulo(2.5m),
                    new Circulo(1.5m)
                };

            var resultado = ReporteFormasHelper.Imprimir(formas, italiano);

            Assert.IsTrue(resultado.Contains("3 Cerchi"));
            Assert.IsTrue(resultado.Contains("Area 34.95"));
            Assert.IsTrue(resultado.Contains("Perimetro 31.42"));
        }

        [Test]
        public void TestResumenListaConMasCirculosIngles()
        {
            var formas = new List<IFormaGeometrica>
                {
                    new Circulo(8),
                    new Circulo(3),
                    new Circulo(2)
                };

            var resultado = ReporteFormasHelper.Imprimir(formas, ingles);

            Assert.IsTrue(resultado.Contains("3 Circles"));
            Assert.IsTrue(resultado.Contains("Area 60.48"));
            Assert.IsTrue(resultado.Contains("Perimeter 40.84"));
        }

        [Test]
        public void TestResumenListaConMasTriangulosCastellano()
        {
            var formas = new List<IFormaGeometrica>
                {
                    new TrianguloEquilatero(3),
                    new TrianguloEquilatero(5),
                    new TrianguloEquilatero(6)
                };

            var resultado = ReporteFormasHelper.Imprimir(formas, castellano);

            Assert.IsTrue(resultado.Contains("3 Triángulos"));
            Assert.IsTrue(resultado.Contains("Area 30.31"));
            Assert.IsTrue(resultado.Contains("Perímetro 42.00"));
        }

        [Test]
        public void TestResumenListaConMasTriangulosItaliano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new TrianguloEquilatero(7),
                new TrianguloEquilatero(4),
                new TrianguloEquilatero(2)
            };

            var resultado = ReporteFormasHelper.Imprimir(formas, italiano);

            Assert.IsTrue(resultado.Contains("3 Triangoli"));
            Assert.IsTrue(resultado.Contains("Area 29.88"));
            Assert.IsTrue(resultado.Contains("Perimetro 39.00"));
        }

        [Test]
        public void TestResumenListaConMasTriangulosIngles()
        {
            var formas = new List<IFormaGeometrica>
                {
                    new TrianguloEquilatero(3.5m),
                    new TrianguloEquilatero(6),
                    new TrianguloEquilatero(1)
                };

            var resultado = ReporteFormasHelper.Imprimir(formas, ingles);

            Assert.IsTrue(resultado.Contains("3 Triangles"));
            Assert.IsTrue(resultado.Contains("Area 21.33"));
            Assert.IsTrue(resultado.Contains("Perimeter 31.50"));
        }

        [Test]
        public void TestResumenListaConMasRectangulosCastellano()
        {
            var formas = new List<IFormaGeometrica>
                {
                    new Rectangulo(3, 4),
                    new Rectangulo(5, 2),
                    new Rectangulo(6, 1)
                };

            var resultado = ReporteFormasHelper.Imprimir(formas, castellano);

            Assert.IsTrue(resultado.Contains("3 Rectángulos"));
            Assert.IsTrue(resultado.Contains("Area 28.00"));
            Assert.IsTrue(resultado.Contains("Perímetro 42.00"));
        }

        [Test]
        public void TestResumenListaConMasRectangulosItaliano()
        {
            var formas = new List<IFormaGeometrica>
                {
                    new Rectangulo(2, 6),
                    new Rectangulo(7, 1),
                    new Rectangulo(4, 3)
                };

            var resultado = ReporteFormasHelper.Imprimir(formas, italiano);

            Assert.IsTrue(resultado.Contains("3 Rettangoli"));
            Assert.IsTrue(resultado.Contains("Area 31.00"));
            Assert.IsTrue(resultado.Contains("Perimetro 46.00"));
        }

        [Test]
        public void TestResumenListaConMasRectangulosIngles()
        {
            var formas = new List<IFormaGeometrica>
                {
                    new Rectangulo(2, 4),
                    new Rectangulo(6, 2),
                    new Rectangulo(3, 5)
                };

            var resultado = ReporteFormasHelper.Imprimir(formas, ingles);

            Assert.IsTrue(resultado.Contains("3 Rectangles"));
            Assert.IsTrue(resultado.Contains("Area 35.00"));
            Assert.IsTrue(resultado.Contains("Perimeter 44"));
        }

        [Test]
        public void TestResumenListaConMasTrapeciosCastellano()
        {
            var formas = new List<IFormaGeometrica>
                {
                    new Trapecio(10, 6, 3, 2, 2),
                    new Trapecio(8, 4, 2, 3, 3),
                    new Trapecio(7, 5, 4, 1, 1)
                };

            var resultado = ReporteFormasHelper.Imprimir(formas, castellano);

            Assert.IsTrue(resultado.Contains("3 Trapecios"));
            Assert.IsTrue(resultado.Contains("Area 60.00"));
            Assert.IsTrue(resultado.Contains("Perímetro 52.00"));
        }

        [Test]
        public void TestResumenListaConMasTrapeciosItaliano()
        {
            var formas = new List<IFormaGeometrica>
                {
                    new Trapecio(9, 5, 3, 2, 2),
                    new Trapecio(6, 4, 2, 3, 3),
                    new Trapecio(7, 3, 2, 1, 1)
                };

            var resultado = ReporteFormasHelper.Imprimir(formas, italiano);

            Assert.IsTrue(resultado.Contains("3 Trapezi"));
            Assert.IsTrue(resultado.Contains("Area 41.00"));
            Assert.IsTrue(resultado.Contains("Perimetro 46.00"));
        }

        [Test]
        public void TestResumenListaConMasTrapeciosIngles()
        {
            var formas = new List<IFormaGeometrica>
                {
                    new Trapecio(10, 4, 2, 3, 3),
                    new Trapecio(8, 6, 3, 2, 2),
                    new Trapecio(7, 5, 4, 1, 1)
                };

            var resultado = ReporteFormasHelper.Imprimir(formas, ingles);

            Assert.IsTrue(resultado.Contains("3 Trapezoids"));
            Assert.IsTrue(resultado.Contains("Area 59.00"));
            Assert.IsTrue(resultado.Contains("Perimeter 52.00"));
        }

        #endregion

        #region Test's para validar la impresión de varias formas geométricas en varios idiomas
        [Test]
        public void TestResumenListaConMasTiposItaliano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resultado = ReporteFormasHelper.Imprimir(formas, italiano);

            Assert.IsTrue(resultado.Contains("2 Quadrati"));
            Assert.IsTrue(resultado.Contains("2 Cerchi"));
            Assert.IsTrue(resultado.Contains("3 Triangoli"));
            Assert.IsTrue(resultado.Contains("TOTALE"));
        }

        [Test]
        public void TestResumenListaConMasTiposCastellano_RectanguloYTrapecio()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Rectangulo(4, 2),
                new Trapecio(6, 4, 3, 2, 2)
            };

            var resultado = ReporteFormasHelper.Imprimir(formas, castellano);

            Assert.IsTrue(resultado.Contains("Rectángulo"));
            Assert.IsTrue(resultado.Contains("Trapecio"));
            Assert.IsTrue(resultado.Contains("TOTAL"));
        }

        [Test]
        public void TestResumenListaConMasTiposIngles_TrianguloEquilateroYRectangulo()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Rectangulo(4, 2),
                new TrianguloEquilatero(6)
            };

            var resultado = ReporteFormasHelper.Imprimir(formas, castellano);

            Assert.IsTrue(resultado.Contains("Rectángulo"));
            Assert.IsTrue(resultado.Contains("Triángulo"));
            Assert.IsTrue(resultado.Contains("TOTAL"));
        }
 
        #endregion
    }
}
