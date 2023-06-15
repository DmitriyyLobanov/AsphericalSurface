using AsphericalSurface.ConsoleView;
using AsphericalSurface.Interfaces;
using AsphericalSurface.Lenses;
using AsphericalSurface.Lenses.Aspherical;
using AsphericalSurface.Lenses.Spherical;

namespace AsphericalSurface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILensStorage ls = new LensStorage();
            ISurfaceDotsCreator sdf = new SurfaceDotsCreator();
            IController controller = new Controller(ls, sdf);

            

            View view = new View(controller);
            view.PrimaryPage();
        }

        
    }

}