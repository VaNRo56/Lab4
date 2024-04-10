using System;
using System.Collections.Generic;
using System.Linq;


namespace Project
{

   

   

    class Program
    {
        static void Main(string[] args)
        {
            TourPackageColl packageCollection = new TourPackageColl();

            
            packageCollection.AddPackage(new TourPackage("Beach Vacation", "Relaxation", 7, "Plane", "All Inclusive", 1000));
            packageCollection.AddPackage(new TourPackage("City Tour", "Sightseeing", 3, "Bus", "Breakfast Only", 500));
            packageCollection.AddPackage(new TourPackage("Spa Retreat", "Wellness", 5, "Car", "Half Board", 1200));
            packageCollection.AddPackage(new TourPackage("Shopping Extravaganza", "Shopping", 4, "Train", "No Meals", 800));

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Display Tour Packages");
                Console.WriteLine("2. Sort Tour Packages by Price");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        packageCollection.DisplayPackages();
                        break;
                    case "2":
                        packageCollection.SortPackagesByPrice();
                        Console.WriteLine("Packages sorted by price.");
                        packageCollection.DisplayPackages();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter again.");
                        break;
                }
            }
        }
    }
}