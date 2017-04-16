// © 2017 Chris Wilson. All Rights Reserved
// Created: 04/14/2017 2:16 PM

using System;
using System.Collections.Generic;
using System.Linq;

namespace Units
{
    // Stores the value internally in Meters per second
    public class Velocity : IUnit
    {
        #region Public Constructors

        public Velocity(double value, VelocityTypes type)
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
            return "meters per second";
        }

        public double DefaultUnitValue()
        {
            return _value;
        }

        public void SetValue(double value, VelocityTypes type)
        {
            switch (type)
            {
                case VelocityTypes.MetersPerHour:
                    _value = value * 0.0002778;
                    break;

                case VelocityTypes.MetersPerSecond:
                    _value = value;
                    break;

                case VelocityTypes.FeetPerSecond:
                    _value = value * 0.3048;
                    break;

                case VelocityTypes.KilometersPerSecond:
                    _value = value * 1000;
                    break;

                case VelocityTypes.KilometersPerHour:
                    _value = value * 0.2777778;
                    break;

                case VelocityTypes.Mach:
                    _value = value * 343;
                    break;

                case VelocityTypes.MilesPerHour:
                    _value = value * 0.44704;
                    break;
            }
        }

        public double ToFeetPerSecond() => _value * 3.28084;

        public double ToKilometersPerHour() => _value * 60 * 60 * 0.001;

        public double ToKilometersPerSecond() => _value * 0.001;

        public double ToMach() => _value * 0.00291545;

        public double ToMetersPerHour() => _value * 60 * 60;

        public double ToMetersPerSecond() => _value;

        public double ToMilesPerHour() => _value * 2.23694;

        public List<string> UnitTypes()
        {
            return Enum.GetValues(typeof(VelocityTypes)).Cast<string>().ToList();
        }

        #endregion Public Methods
    }
}