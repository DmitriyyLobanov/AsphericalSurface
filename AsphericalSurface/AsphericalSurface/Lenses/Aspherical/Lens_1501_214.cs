using AsphericalSurface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Lenses.Aspherical
{
    internal class Lens_1501_214 : Lens
    {

        public Lens_1501_214()
        {
            this.LensName = "1501.214";
            this.Surface = SURFACE_TYPES.ASPHERICAL;
            this.LensThinckness = 0.355;
            this.LensWidth = 0.4;
            this.Radius = 0.235;
            this.CV = 4.251594;
            this.K =-1;
            this.CoefA4 = 5.143152;
            this.CoefA6 = 6.150901;
            this.CoefA8 = 221.6577;
            this.CoefA10 = -5168;
            this.CoefA12 = 11676;
        }



        public override string? ToString()
        {
            string result;
            result = "Имя продукта: " + LensName + "\n" +
                "Тип поверхности: " + Surface.ToString() + "\n" +
                "Толщина линзы: " + LensThinckness + "\n" +
                "Ширина линзы: " + LensWidth +"\n" +
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
    }
}
