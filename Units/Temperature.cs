// © 2017 Chris Wilson. All Rights Reserved
// Created: 04/14/2017 6:34 PM

using System;
using System.Collections.Generic;
using System.Linq;

namespace Units
{
    public class Temperature : IUnit
    {
        #region Public Constructors

        public Temperature(double value, TemperatureTypes type)
        {
            SetValue(value, type);
        }

        #endregion Public Constructors



        #region Private Fields

        private double _value;

        #endregion Private Fields

        public string DefaultUnitType()
        {
            return "degree Celcius";
        }

        public double DefaultUnitValue()
        {
            return _value;
        }

        public double ToCelcius() => _value;

        public double ToFarenheight() => _value * 1.8 + 32;

        public double ToKelvin() => _value + 273.15;

        public List<string> UnitTypes()
        {
            return Enum.GetValues(typeof(TemperatureTypes)).Cast<string>().ToList();
        }

        #region Public Methods

        public void SetValue(double value, TemperatureTypes type)
        {
            switch (type)
            {
                case TemperatureTypes.Celcius:
                    _value = value;
                    break;

                case TemperatureTypes.Farenheight:
                    _value = (value - 32) / 1.8;
                    break;

                case TemperatureTypes.Kelvin:
                    _value = value - 273.15;
                    break;
            }
        }

        #endregion Public Methods
    }
}