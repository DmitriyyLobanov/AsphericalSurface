using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Lenses.Aspherical
{
    internal class Lens_1401_003 : Lens
    {


        public Lens_1401_003()
        {
            this.LensName = "1401.003";
            this.Surface = SURFACE_TYPES.ASPHERICAL;
            this.LensThinckness = 2.81;
            this.LensWidth = 10.5;
            this.Radius = 21.373;
            this.CV = 0.04678788;
            this.K = -1;
            this.CoefA4 = 0.00000322911;
            this.CoefA6 = 0.00000000921956;
            this.CoefA8 = 0.0000000004287432;
            this.CoefA10 = 0.000000000009985725;
            this.CoefA12 = 0.000000000000085849;
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
                "A10: " + CoefA10 + "\n" +
                "A12: " + CoefA12 + "\n";
            return result;
        }
    }
}
