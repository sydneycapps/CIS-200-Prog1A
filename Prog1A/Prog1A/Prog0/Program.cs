// Program 1A
// CIS 200-01
// Fall 2018
// Due: 9/24/2017
// By: D5236

// File: Program.cs
// Simple test program for initial Parcel classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Small list of Parcels is created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ", 
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", 
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321", 
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter l1 = new Letter(a1, a3, 0.50M); // Test Letter 1
            Letter l2 = new Letter(a2, a4, 1.20M); // Test Letter 2
            Letter l3 = new Letter(a4, a1, 1.70M); // Test Letter 3

            GroundPackage gp1 = new GroundPackage(a2, a1, 5, 6, 7, 8); // Test GroundPackage 1
            GroundPackage gp2 = new GroundPackage(a4, a2, 75, 75, 75, 50); // Test GroundPackage 2

            NextDayAirPackage nextDayAir1 = new NextDayAirPackage(a4, a3, 50, 50, 50, 25, 10); // Test NextDayAirPackage 1
            NextDayAirPackage nextDayAir2 = new NextDayAirPackage(a1, a3, 25, 25, 25, 100, 8); // Test NextDayAirPackage 2
            NextDayAirPackage nextDayAir3 = new NextDayAirPackage(a2, a4, 50, 50, 50, 100, 15); // Test NextDayAirPackage 3

            TwoDayAirPackage twoDayAir1 = new TwoDayAirPackage(a3, a2, 50, 25, 50, 30, TwoDayAirPackage.Delivery.Saver); // Test TwoDayAirPackage 1
            TwoDayAirPackage twoDayAir2 = new TwoDayAirPackage(a4, a1, 10, 10, 10, 10, TwoDayAirPackage.Delivery.Early); // Test TwoDayAirPackage 2

            List<Parcel> parcels = new List<Parcel>(); // Test list of parcels

            // Add test data to list
            parcels.Add(l1);
            parcels.Add(l2);
            parcels.Add(l3);

            // Display data
            Console.WriteLine("Program 0 - List of Parcels\n");

            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("--------------------");
            }

            List<Package> packages = new List<Package>(); // Test list of packages

            // Add test data to list
            packages.Add(gp1);
            packages.Add(gp2);
            packages.Add(nextDayAir1);
            packages.Add(nextDayAir2);
            packages.Add(nextDayAir3);
            packages.Add(twoDayAir1);
            packages.Add(twoDayAir2);

            // Display data
            Console.WriteLine("Program 1A - List of Packages\n");

            foreach(Package package in packages)
            {
                Console.WriteLine(package);
                Console.WriteLine("--------------------");
            }
        }
    }
}
