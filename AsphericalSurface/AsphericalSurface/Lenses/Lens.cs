using AsphericalSurface.Interfaces;
using AsphericalSurface.Lenses.Aspherical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Lenses
{
    internal class Lens : ILens
    {
        public string? LensName { get; protected set; }
        public SURFACE_TYPES Surface { get; protected set; }
        public double LensThinckness { get; protected set; }
        public double LensWidth { get; protected set; }
        public double Radius { get; protected set; }
        public double CV { get; protected set; }
        public double K { get; protected set; }
        public double CoefA4 { get; protected set; }
        public double CoefA6 { get; protected set; }
        public double CoefA8 { get; protected set; }
        public double CoefA10 { get; protected set; }
        public double CoefA12 { get; protected set; }

        /// <summary>
        /// Метод расчёта макрозаготовки для микролинзы
        /// </summary>
        /// <param name="magnificationFactor">коэффициент увеличения микролинзы</param>
        /// <returns>экземпляр линзы со свойствами соответствующими макрозаготовке</returns>
        public Lens CalculateMacro(double magnificationFactor)
        {
            SURFACE_TYPES macroSurface = this.Surface;

            string? name = this.LensName;
            double macroThinckness = this.LensThinckness * magnificationFactor;
            double macroWidth = this.LensWidth * magnificationFactor;

            double macroRadius = this.Radius * magnificationFactor;
            double macroCV = 1 / macroRadius;
            double macroK = this.K;

            double coefA4 = this.CoefA4 / Math.Pow(magnificationFactor, 3);
            double coefA6 = this.CoefA6 / Math.Pow(magnificationFactor, 5);
            double coefA8 = this.CoefA8 / Math.Pow(magnificationFactor, 7);
            double coefA10 = this.CoefA10 / Math.Pow(magnificationFactor, 9);
            double coefA12 = this.CoefA12 / Math.Pow(magnificationFactor, 11);

            if (this.Surface == SURFACE_TYPES.ASPHERICAL)
            {
                Lens macroLens = new Lens
                {
                    LensName = name + "_" + "MacroLens" + "_" + $"x{magnificationFactor}",
                    Surface = macroSurface,
                    LensThinckness = macroThinckness,
                    LensWidth = macroWidth,
                    Radius = macroRadius,
                    CV = macroCV,
                    K = macroK,
                    CoefA4 = coefA4,
                    CoefA6 = coefA6,
                    CoefA8 = coefA8,
                    CoefA10 = coefA10,
                    CoefA12 = coefA12
                };
                return macroLens;
            }
            else
            {
                Lens macroLens = new Lens
                {
                    LensName = name + "_" + "MacroLens" + "_" + $"x{magnificationFactor}",
                    LensThinckness = macroThinckness,
                    LensWidth = macroWidth,
                    Radius = macroRadius,
                    CV = macroCV
                };
                return macroLens;
            }
        }

        /// <summary>
        /// Строковое представление объекта Lens в зависимости от типа радиальной поверхности.
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            string result;
            if (this.Surface == SURFACE_TYPES.ASPHERICAL)
            {
                result = "Имя продукта: " + LensName + "\n" +
                    "Тип поверхности: " + Surface.ToString() + "\n" +
                    "Толщина линзы: " + LensThinckness + "\n" +
                    "Ширина линзы: " + LensWidth + "\n" +
                    "Радиус при вершине: " + Radius + "\n" +
                    "Кривизна поверхности: " + CV + "\n" +
                    "Коническая постоянная: " + K + "\n" +
                    "A4: " + CoefA4 + "\n" +
                    "A6: " + CoefA6 + "\n" +
                    "A8: " + CoefA8 + "\n" +
                    "A10: " + CoefA10 + "\n" +
                    "A12: " + CoefA12 + "\n";
                return result;
            }
            else 
            {
                result = "Имя продукта: " + LensName + "\n" +
                    "Тип поверхности: " + Surface.ToString() + "\n" +
                    "Толщина линзы: " + LensThinckness + "\n" +
                    "Ширина линзы: " + LensWidth + "\n" +
                    "Радиус: " + Radius;
                return result;
            }

        }

    }
}
