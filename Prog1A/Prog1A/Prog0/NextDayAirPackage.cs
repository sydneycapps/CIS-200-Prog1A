// Program 1A
// CIS 200-01
// Fall 2018
// Due: 9/24/2017
// By: D5236

// File: NextDayAirPackage.cs

// The NextDayAirPackage class is a concrete derived class of AirPackage.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public class NextDayAirPackage : AirPackage
    {
        private decimal _expressFee; // Fee for next day air
        public decimal shippingCost; // Next day air package's shipping cost
        public decimal baseCost; // Calculation of the base cost
        public decimal heavyCharge; // Calculation of the heavy charge cost
        public decimal largeCharge; // Calculation of the large charge cost
        public const decimal BASE_FACTOR = .40M; // Base factor for calculating the base cost
        public const decimal WEIGHT_FACTOR = .30M; // Weight factor for calculating the base cost
        public const decimal EXTRA_CHARGE = .25M; // Extra charge for calculating the heavy and large charges

        // Precondition: Express fee >= 0
        // Postcondition: The next day air package is created with the specified length, width, height, weight, origin address, destination address, and express fee.
        public NextDayAirPackage(Address originAddress, Address destAddress, double length, double width,
            double height, double weight, decimal expressFee)
            : base(originAddress, destAddress, length, width, height, weight)
        {
            ExpressFee = expressFee;
        }

        public decimal ExpressFee
        {
            // Precondition: None
            // Postcondition: The next day air package's express fee is returned.
            get
            {
                return _expressFee;
            }

            // Precondition: Value >= 0
            // Postcondition: The next day air package's express fee is set to specified value.
            private set
            {
                if (value >= 0)
                    _expressFee = value;
                else
                    throw new ArgumentOutOfRangeException("ExpressFee", value, "ExpressFee must be >= 0");
            }
        }

        // Precondition: None
        // Postcondtion: The next day air package's shipping cost is calculated and returned.
        public override decimal CalcCost()
        {
            baseCost = (BASE_FACTOR * (decimal)(Length + Width + Height)) + (WEIGHT_FACTOR * (decimal)Weight) + ExpressFee;
            heavyCharge = EXTRA_CHARGE * (decimal)Weight;
            largeCharge = EXTRA_CHARGE * (decimal)(Length + Width + Height);

            if (IsHeavy() && IsLarge())
                shippingCost = baseCost + heavyCharge + largeCharge;
            else if (IsHeavy())
                shippingCost = baseCost + heavyCharge;
            else if (IsLarge())
                shippingCost = baseCost + largeCharge;
            else
                shippingCost = baseCost;

            return shippingCost;
        }

        // Precondition: None
        // Postcondition: A string with the next day air package's data has been returned.
        public override string ToString()
        {
            string NL = Environment.NewLine; // New line shortcut

            return $"Next Day Air Package{NL}Origin Address:{NL}{OriginAddress}{NL}{NL}Destination Address:{NL}{DestinationAddress}{NL}{NL}" +
                   $"Length: {Length}{NL}Width: {Width}{NL}Height: {Height}{NL}Weight: {Weight}{NL}" +
                   $"Express Fee: {ExpressFee:C}{NL}Shipping Cost: {CalcCost():C}{NL}";
        }
    }
}
