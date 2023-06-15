using AsphericalSurface.Lenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Interfaces
{
    internal interface IController
    {
        /// <summary>
        /// Метод получения списка имен доступных линз
        /// </summary>
        /// <returns>список имен линз</returns>
        public string[] getLensNames();

        /// <summary>
        /// Метод получения одиночной линзы по имени
        /// </summary>
        /// <param name="lensName">имя линзы</param>
        /// <returns></returns>
        public Lens GetSinleLens(string lensName);

        /// <summary>
        /// Метод проверки вхождения имени-аргумента в список имен доступных линз
        /// </summary>
        /// <param name="lensName"></param>
        /// <returns></returns>
        public bool CheckContains(string lensName);

        /// <summary>
        /// Метод создания файла содержащего массив точек поверхности линзы
        /// </summary>
        /// <param name="lens"></param>
        public void CreateDots(ILens lens);
    }
}
