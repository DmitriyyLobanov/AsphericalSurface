using AsphericalSurface.Lenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Interfaces
{
    internal interface ILens
    {
        public string? LensName { get; }
        public SURFACE_TYPES Surface { get; }
        public double LensThinckness { get; }
        public double LensWidth { get; }
        public double Radius { get; }
        public double CV { get; }
        public double K { get; }
        public double CoefA4 { get; }
        public double CoefA6 { get; }
        public double CoefA8 { get; }
        public double CoefA10 { get; }
        public double CoefA12 { get; }

        /// <summary>
        /// Метод расчёта макрозаготовки для микролинзы
        /// </summary>
        /// <param name="magnificationFactor">коэффициент увеличения микролинзы</param>
        /// <returns>экземпляр линзы со свойствами соответствующими макрозаготовке</returns>
        public Lens CalculateMacro(double magnificationFactor);

        /// <summary>
        /// Строковое представление объекта Lens в зависимости от типа радиальной поверхности.
        /// </summary>
        /// <returns></returns>
        public string? ToString();
    }
}
