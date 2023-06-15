using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Lenses.Spherical
{
    internal class Lens_1401_009 : Lens
    {

        public Lens_1401_009()
        {
            this.LensName ="1401.009";
            this.Surface = SURFACE_TYPES.SPHERICAL;
            this.LensThinckness = 2.8;
            this.LensWidth = 5;
            this.Radius = 11.701;
            this.CV = 0.0846278;
        }


        public override string? ToString()
        {
            string result;
            result = "Имя продукта: " + LensName + "\n" +
                "Тип поверхности: " + Surface.ToString() + "\n" +
                "Толщина линзы: " + LensThinckness + "\n" +
                "Ширина линзы: " + LensWidth + "\n" +
                "Радиус: " + Radius;
            return result;
        }
    }
}
