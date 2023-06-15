using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Lenses.Aspherical
{
    internal class Lens_1503_011 : Lens
    {

        public Lens_1503_011()
        {
            this.LensName = "1503.011";
            this.Surface = SURFACE_TYPES.ASPHERICAL;
            this.LensThinckness = 0.435;
            this.LensWidth = 0.54;
            this.Radius = 0.261;
            this.CV = 3.837296;
            this.K = -0.9260063;
            this.CoefA4 = 3.764034;
            this.CoefA6 = 3.453931;
            this.CoefA8 = 240.3144;
            this.CoefA10 = -2727.862;
        }



        public override string? ToString()
        {
            string result;
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
                "A10: " + CoefA10;
            return result;
        }

    }
}
