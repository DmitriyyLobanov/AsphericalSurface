using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Lenses.Aspherical
{
    internal class Lens_9007_301 : Lens
    {


        public Lens_9007_301()
        {
            this.LensName = "9007.301";
            this.Surface = SURFACE_TYPES.ASPHERICAL;
            this.LensThinckness = 1.5;
            this.LensWidth = 1.4;
            this.Radius = 0.752;
            this.CV = 1.32965;
            this.K = -1;
            this.CoefA4 = 0.1880586;
            this.CoefA6 = 0.15748;
            this.CoefA8 = -0.2727987;
            this.CoefA10 = 0.8328194;
            this.CoefA12 = -0.7623471;
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
