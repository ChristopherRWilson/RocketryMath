// © 2017 Chris Wilson. All Rights Reserved
// Created: 04/14/2017 2:25 PM

using System;
using System.Collections.Generic;
using System.Linq;

namespace Units
{
    // Stores the value internally in grams
    public class Mass : IUnit
    {
        #region Public Constructors

        public Mass(double value, MassTypes type)
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
            return "gram";
        }

        public double DefaultUnitValue()
        {
            return _value;
        }

        public void SetValue(double value, MassTypes type)
        {
            switch (type)
            {
                case MassTypes.Grams:
                    _value = value;
                    break;

                case MassTypes.Kilograms:
                    _value = value * 1000;
                    break;

                case MassTypes.Ounces:
                    _value = value * 28.3495;
                    break;

                case MassTypes.Pounds:
                    _value = value * 453.592;
                    break;
            }
        }

        public double ToGrams() => _value;

        public double ToKilograms() => _value / 1000;

        public double ToOunces() => _value * 0.035274;

        public double ToPounds() => _value * 0.00220462;

        public List<string> UnitTypes()
        {
            return Enum.GetValues(typeof(MassTypes)).Cast<string>().ToList();
        }

        #endregion Public Methods
    }
}