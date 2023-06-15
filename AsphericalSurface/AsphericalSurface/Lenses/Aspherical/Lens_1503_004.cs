using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Lenses.Aspherical
{
    internal class Lens_1503_004 : Lens
    {


        public Lens_1503_004()
        {
            this.LensName = "1503.004";
            this.Surface = SURFACE_TYPES.ASPHERICAL;
            this.LensThinckness = 0.398;
            this.LensWidth = 0.5;
            this.Radius = 0.244;
            this.CV = 4.093328;
            this.K = -0.7134;
            this.CoefA4 = 2.454381;
            this.CoefA6 = 10.96657;
            this.CoefA8 = -21.5626;
            this.CoefA10 = 113.6667;
            this.CoefA12 = -26286.65;
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
