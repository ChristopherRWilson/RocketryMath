// © 2017 Chris Wilson. All Rights Reserved
// Created: 04/14/2017 2:25 PM

using System;
using System.Collections.Generic;
using System.Linq;

namespace Units
{
    // Stores the value internally in meters
    public class Distance : IUnit
    {
        #region Public Constructors

        public Distance(double value, DistanceTypes type)
        {
            SetValue(value, type);
        }

        #endregion Public Constructors



        #region Private Fields

        private double _value;

        #endregion Private Fields

        #region Public Methods

        public string DefaultUnitType()
        {
            return "meter";
        }

        public double DefaultUnitValue()
        {
            return _value;
        }

        public void SetValue(double value, DistanceTypes type)
        {
            switch (type)
            {
                case DistanceTypes.Meters:
                    _value = value;
                    break;

                case DistanceTypes.Kilometers:
                    _value = value * 1000;
                    break;

                case DistanceTypes.Feet:
                    _value = value * 0.3048;
                    break;

                case DistanceTypes.Inches:
                    _value = value * 0.0254;
                    break;

                case DistanceTypes.Miles:
                    _value = value * 1609.344;
                    break;

                case DistanceTypes.Centimeters:
                    _value = value * 0.01;
                    break;

                case DistanceTypes.Millimeters:
                    _value = value * 0.001;
                    break;

                case DistanceTypes.Yards:
                    _value = value * 0.9144;
                    break;
            }
        }

        public double ToCentimeters() => _value * 100;

        public double ToFeet() => _value * 3.28084;

        public double ToInches() => _value * 39.3701;

        public double ToKilometers() => _value * 0.001;

        public double ToMeters() => _value;

        public double ToMiles() => _value * 0.000621371;

        public double ToMillimeters() => _value * 1000;

        public double ToYards() => _value * 1.09361;

        public List<string> UnitTypes()
        {
            return Enum.GetValues(typeof(DistanceTypes)).Cast<string>().ToList();
        }

        #endregion Public Methods
    }
}