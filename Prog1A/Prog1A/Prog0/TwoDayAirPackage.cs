// Program 1A
// CIS 200-01
// Fall 2018
// Due: 9/24/2017
// By: D5236

// File: TwoDayAirPackage.cs

// The TwoDayAirPackage class is a concrete derived class of AirPackage.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public class TwoDayAirPackage : AirPackage
    {
        public enum Delivery { Early, Saver}; // Defines two choice enumeration for Delivery
        private Delivery _deliveryType; // The two day air package's delivery type
        public decimal baseCost; // Calculation of the base cost
        public decimal saverCost; // Calculation of the saver cost
        public decimal shippingCost; // Two day air package's shipping cost
        public const decimal COST_FACTOR = .25M; // Cost factor for calculating the base cost
        public const decimal SAVER_FACTOR = .90M; // Saver factor for calculating the saver cost.

        // Precondition: value == Delivery.Early || value == Delivery.Saver
        // Postcondition: The two day air package is created with the specified length, width, height, weight, origin address, destination address, and delivery type.
        public TwoDayAirPackage(Address originAddress, Address destAddress, double length, double width,
            double height, double weight, Delivery deliveryType)
            : base(originAddress, destAddress, length, width, height, weight)
        {
            DeliveryType = deliveryType;
        }

        public Delivery DeliveryType
        {
            // Precondition: None
            // Postcondition: The delivery type is returned.
            get
            {
                return _deliveryType;
            }

            // Precondition: value == Delivery.Early || value == Delivery.Saver
            // Postcondition: The two day air package's delivery type is set to specified value.
            set
            {
                if (value == Delivery.Early || value == Delivery.Saver)
                    _deliveryType = value;
                else
                    throw new ArgumentOutOfRangeException("DeliveryType", value, "DeliveryType must be Early or Saver");
            }
        }

        // Precondition: None
        // Postcondition: The two day air package's cost is calculated and returned.
        public override decimal CalcCost()
        {
            baseCost = COST_FACTOR * (decimal)(Length + Width + Height) + COST_FACTOR * (decimal)Weight;
            saverCost = baseCost * SAVER_FACTOR;

            if (DeliveryType == Delivery.Saver)
                shippingCost = saverCost;
            else
                shippingCost = baseCost;

            return shippingCost;
        }

        // Precondition: None
        // Postcondition: A string with the two day air package's data has been returned.
        public override string ToString()
        {
            string NL = Environment.NewLine; // New line shortcut

            return $"Two Day Air Package{NL}Origin Address:{NL}{OriginAddress}{NL}{NL}Destination Address:{NL}{DestinationAddress}{NL}{NL}" +
                   $"Length: {Length}{NL}Width: {Width}{NL}Height: {Height}{NL}Weight: {Weight}{NL}" +
                   $"Delivery Type: {DeliveryType}{NL}Shipping Cost: {CalcCost():C}{NL}";
        }
    }
}
