// Program 1A
// CIS 200-01
// Fall 2018
// Due: 9/24/2017
// By: D5236

// File: Package.cs

// The Package class is an abstract derived class of Parcel.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public abstract class Package : Parcel
    {
        private double _length; // Package's length
        private double _width;  // Package's width
        private double _height; // Package's height
        private double _weight; // Package's weight

        // Precondition: Length, width, height, and weight >= 0
        // Postcondition: The package is created with the specified length, width, height, weight, origin address, and destination address.
        public Package(Address originAddress, Address destAddress, double length, double width,
            double height, double weight)
            :base(originAddress, destAddress)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }

        public double Length
        {
            // Precondition: None
            // Postcondition: The package's length has been returned.
            get
            {
                return _length;
            }

            // Precondition: value >= 0
            // Postcondition: The package's length has been set to specified value.
            set
            {
                if (value >= 0)
                    _length = value;
                else
                    throw new ArgumentOutOfRangeException("Length", value, "Length must be >= 0");
            }
        }

        public double Width
        {
            // Precondition: None
            // Postcondition: The package's width has been returned.
            get
            {
                return _width;
            }

            // Precondition: value >= 0
            // Postcondition: The package's width has been set to specified value.
            set
            {
                if (value >= 0)
                    _width = value;
                else
                    throw new ArgumentOutOfRangeException("Width", value, "Width must be >= 0");
            }
        }

        public double Height
        {
            // Precondition: None
            // Postcondition: The package's height has been returned.
            get
            {
                return _height;
            }

            // Precondition: value >= 0
            // Postcondition: The package's height has been set to specified value.
            set
            {
                if (value >= 0)
                    _height = value;
                else
                    throw new ArgumentOutOfRangeException("Height", value, "Height must be >= 0");
            }
        }

        public double Weight
        {
            // Precondition: None
            // Postcondition: The package's weight has been returned.
            get
            {
                return _weight;
            }

            // Precondition: value >= 0
            // Postcondition: The package's weight has been set to specified value.
            set
            {
                if (value >= 0)
                    _weight = value;
                else
                    throw new ArgumentOutOfRangeException("Weight", value, "Weight must be >= 0");
            }
        }

        // Precondition: None
        // Postcondition: A string with the package's data has been returned.
        public override String ToString()
        {
            string NL = Environment.NewLine; // New line shortcut

            return $"Origin Address:{NL}{OriginAddress}{NL}{NL}Destiniation Address:{NL}{DestinationAddress}{NL}" +
                   $"Length: {Length}{NL}Width: {Width}{NL}Height: {Height}{NL}Weight: {Weight}{NL}";
        }
    }
}
