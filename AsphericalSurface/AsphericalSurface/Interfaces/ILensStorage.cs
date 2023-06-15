using AsphericalSurface.Lenses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Interfaces
{
    internal interface ILensStorage
    {
        public ArrayList Storage { get; }

        public int Lenght();

        /// <summary>
        /// Метод получения объекта линзы из хранилища по индексу
        /// </summary>
        /// <param name="i">индекс</param>
        /// <returns>линза</returns>
        public Lens GetLens(int i);

        /// <summary>
        /// Метод получения объекта линзы из хранилища по имени
        /// </summary>
        /// <param name="lensName">имя линзы</param>
        /// <returns>линза</returns>
        public Lens GetLens(string lensName);


    }
}
