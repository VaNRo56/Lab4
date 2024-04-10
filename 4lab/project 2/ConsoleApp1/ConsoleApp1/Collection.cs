using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
   
    class TourPackageColl
    {
        private List<TourPackage> packages;

        public TourPackageColl()
        {
            packages = new List<TourPackage>();
        }

        public void AddPackage(TourPackage package)
        {
            packages.Add(package);
        }

        public void DisplayPackages()
        {
            Console.WriteLine("Available Tour Packages:");
            foreach (var package in packages)
            {
                Console.WriteLine(package);
            }
            Console.WriteLine();
        }

        public void SortPackagesByPrice()
        {
            packages = packages.OrderBy(p => p.Price).ToList();
        }
    }
}
