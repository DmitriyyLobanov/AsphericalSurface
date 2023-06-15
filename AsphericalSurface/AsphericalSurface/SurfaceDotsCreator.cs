using AsphericalSurface.Interfaces;
using AsphericalSurface.Lenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface
{
    internal class SurfaceDotsCreator : ISurfaceDotsCreator
    {

        public SurfaceDotsCreator() { }

        /// <summary>
        /// Метод создания файла содержащего массив точек поверхности линзы.
        /// </summary>
        /// <param name="lens">Линза для расчетов</param>
        public void CreateDotsTXT(ILens lens) 
        {
            string fileName = lens.LensName + ".txt";
            string dots = dotCalc(lens);

            try
            {
                string baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string appStorageFolder = Path.Combine(baseFolder, "AsphericalSurface");

                Directory.CreateDirectory(appStorageFolder);

                File.WriteAllText(Path.Combine(appStorageFolder + @"\", fileName), dots);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            
        }

        private string dotCalc(ILens lens)
        {
            string res = "";
            double y;
            for (double x = -lens.LensWidth / 2; x <= lens.LensWidth / 2; x += 0.001)
            {
                y = Math.Pow(x, 2) / (lens.Radius + Math.Sqrt((Math.Pow(lens.Radius, 2) - (1 + lens.K) * Math.Pow(x, 2)))) + lens.CoefA4 * Math.Pow(x, 4) + lens.CoefA6 * Math.Pow(x, 6) +
                    +lens.CoefA8 * Math.Pow(x, 8) + lens.CoefA10 * Math.Pow(x, 10) + lens.CoefA12 * Math.Pow(x, 12);
                res += Math.Round(x, 3).ToString().Replace(',', '.') + " " + (-y).ToString().Replace(',', '.') + "\n";
            }
            return res;
        }
    }
}
