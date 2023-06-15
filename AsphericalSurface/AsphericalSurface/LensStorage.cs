using AsphericalSurface.ConsoleView;
using AsphericalSurface.Interfaces;
using AsphericalSurface.Lenses;
using AsphericalSurface.Lenses.Aspherical;
using AsphericalSurface.Lenses.Spherical;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface
{
    internal class LensStorage : ILensStorage
    {
        public ArrayList Storage { get; private set; }

        public LensStorage()
        {
            Storage = new ArrayList();
            Storage.Add(new Lens_1501_214());
            Storage.Add(new Lens_1401_003());
            Storage.Add(new Lens_1503_011());
            Storage.Add(new Lens_1503_004());
            Storage.Add(new Lens_9007_301());
            Storage.Add(new Lens_1275_011());
            Storage.Add(new Lens_1401_009());
            Storage.Add(new Lens_9007_400());
            
        }

        public int Lenght()
        {
            return Storage.Count;
        }
        public Lens GetLens(int i)
        {
            return (Lens)Storage[i];
        }
        public Lens GetLens(string lensName)
        {
            for (int i = 0; i < Storage.Count; i++)
            {
                if (lensName.Equals(GetLens(i).LensName))
                {
                    return GetLens(i);
                }
            }
            return new Lens();
        }
        
    }
}
