using AsphericalSurface.Lenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Interfaces
{
    internal interface ISurfaceDotsCreator
    {
        /// <summary>
        /// Метод создания файла содержащего массив точек поверхности линзы.
        /// </summary>
        /// <param name="lens">Линза для расчетов</param>
        public void CreateDotsTXT(ILens lens);

    }
}
