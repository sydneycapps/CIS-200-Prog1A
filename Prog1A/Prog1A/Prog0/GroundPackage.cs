// Program 1A
// CIS 200-01
// Fall 2018
// Due: 9/24/2017
// By: D5236

// File: GroundPackage.cs

// The GroundPackage class is a concrete derived class of Package.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public class GroundPackage : Package
    {
        private int _zoneDistance; // Ground package's zone distance between the two zip codes
        public decimal cost; // Calculated cost
        public const int ZIP_DENOMINATOR = 10000; // Zip denominator in calculating the zone distance
        public const double DIMENSION_FACTOR = .20; // The dimension factor in the cost formula
        public const double WEIGHT_FACTOR = .05; // The weight factor in the cost formula.

        // Precondition: Length, width, height, and weight >= 0
        // Postcondition: The ground package is created with the specified length, width, height, weight, origin address, and destination address.
        public GroundPackage(Address originAddress, Address destAddress, double length, double width,
            double height, double weight)
            : base(originAddress, destAddress, length, width, height, weight)
        {
        }

        public int ZoneDistance // Helper property
        {
            // Precondition: None
            // Postcondition: The zone distance is calculated and returned.
            get
            {
                _zoneDistance = Math.Abs((OriginAddress.Zip / ZIP_DENOMINATOR) - (DestinationAddress.Zip / ZIP_DENOMINATOR));
                return _zoneDistance;
            }
        }

        // Precondition: None
        // Postcondition: The ground package's cost is calculated and returned.
        public override decimal CalcCost()
        {
            cost = (decimal)DIMENSION_FACTOR * (decimal)(Length + Width + Height) + (decimal)WEIGHT_FACTOR * (decimal)(ZoneDistance + 1) * (decimal)(Weight);

            return cost;
        }

        // Precondition: None
        // Postcondition: A string with the ground package's data has been returned.
        public override string ToString()
        {
            string NL = Environment.NewLine; // New line shortcut

            return $"Ground Package{NL}Origin Address:{NL}{OriginAddress}{NL}{NL}Destination Address:{NL}{DestinationAddress}{NL}{NL}" +
                   $"Length: {Length}{NL}Width: {Width}{NL}Height: {Height}{NL}Weight: {Weight}{NL}" +
                   $"Zone Distance: {ZoneDistance}{NL}Cost: {CalcCost():C}{NL}";
        }
    }
}
