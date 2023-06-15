using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsphericalSurface.Interfaces;
using AsphericalSurface.Lenses;

namespace AsphericalSurface
{
    internal class Controller : IController
    {
        private ILensStorage lensStorage;
        private ISurfaceDotsCreator surfaceDots;

        public Controller(ILensStorage lensStorage, ISurfaceDotsCreator surfaceDots)
        {
            this.lensStorage = lensStorage;
            this.surfaceDots = surfaceDots;
        }

        public string[] getLensNames()
        {
            string[] res = new string[lensStorage.Storage.Count];
            for (int i = 0; i < lensStorage.Storage.Count; i++)
            {
                res[i] = lensStorage.GetLens(i).LensName;
            }
            return res;
        }

        public Lens GetSinleLens(string lensName)
        {
            return lensStorage.GetLens(lensName);
        }
        
        
        public bool CheckContains(string lensName)
        {
            for (int i = 0; i < lensStorage.Storage.Count; i++)
            {
                if (lensStorage.GetLens(i).LensName == lensName)
                {
                    return true;
                }
            }
            return false;
        }

        public void CreateDots (ILens lens)
        {
            surfaceDots.CreateDotsTXT(lens);
        }
    }
}
