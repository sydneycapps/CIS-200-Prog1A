// Program 1A
// CIS 200-01
// Fall 2018
// Due: 9/24/2017
// By: D5236

// File: AirPackage.cs

// The AirPackage class is an abstract base class derived of Package.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public abstract class AirPackage : Package
    {
        public const double HEAVY_WEIGHT = 75; // Heavy package is 75 pounds or more
        public const double LARGE_DIM = 100; // Large package is 100 inches or more
        public double totalDimensions; // Dimensions calculation

        // Precondition: Length, width, height, and weight >= 0
        // Postcondition: The  air package is created with the specified length, width, height, weight, origin address, and destination address.
        public AirPackage (Address originAddress, Address destAddress, double length, double width,
            double height, double weight)
            : base(originAddress, destAddress, length, width, height, weight)
        {

        }

        // Precondition: None
        // Postcondition: Returns a true value if weight >= HEAVY_WEIGHT
        public Boolean IsHeavy()
        {
            if (Weight >= HEAVY_WEIGHT)
                return true;
            else
                return false;
        }

        // Precondition: None
        // Postcondition: Returns a true value if totalDimensions >= LARGE_DIM
        public Boolean IsLarge()
        {
            totalDimensions = (Length + Width + Height);

            if (totalDimensions >= LARGE_DIM)
                return true;
            else
                return false;
        }

        // Precondition: None
        // Postcondition: A string with the air package's data has been returned.
        public override string ToString()
        {
            string NL = Environment.NewLine; // New line shortcut

            return $"Air Package{NL}Origin Address:{NL}{OriginAddress}{NL}{NL}Destination Address:{NL}{DestinationAddress}{NL}{NL}" +
                   $"Length: {Length}{NL}Width: {Width}{NL}Height: {Height}{NL}Weight: {Weight}{NL}" +
                   $"Heavy: {IsHeavy()}{NL}Large: {IsLarge()}{NL}";
        }
    }
}
