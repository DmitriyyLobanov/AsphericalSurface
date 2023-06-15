using AsphericalSurface.Lenses.Aspherical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Lenses.Spherical
{
    internal class Lens_1275_011 : Lens
    {


        public Lens_1275_011()
        {
            this.LensName = "1275.011";
            this.Surface = SURFACE_TYPES.SPHERICAL;
            this.LensThinckness = 1;
            this.LensWidth = 0.98;
            this.Radius = 6.520;
            this.CV = 0.1533742;
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
