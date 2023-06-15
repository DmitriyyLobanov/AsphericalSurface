using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Lenses.Spherical
{
    internal class Lens_9007_400 : Lens
    {


        public Lens_9007_400()
        {
            this.LensName = "9007.400";
            this.Surface = SURFACE_TYPES.SPHERICAL;
            this.LensThinckness = 0.55;
            this.LensWidth = 0.5;
            this.Radius = 1.486;
            this.CV = 0.6729475;
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
