using System;
using System.Collections.Generic;
using System.Linq;

namespace Units
{
    public class Pressure : IUnit
    {
        #region Public Constructors

        public Pressure(double value, PressureTypes type)
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
            return "kilogram/meter^2";
        }

        public double DefaultUnitValue()
        {
            return _value;
        }

        public void SetValue(double value, PressureTypes type)
        {
            switch (type)
            {
                case PressureTypes.KilogramsSquareCentimeter:
                    _value = value;
                    break;

                case PressureTypes.Atmospheres:
                    _value = value * 1.0332274527999;
                    break;

                case PressureTypes.Bars:
                    _value = value * 1.0197162129779;
                    break;

                case PressureTypes.InchesMercury:
                    _value = value * 0.034531465893042;
                    break;

                case PressureTypes.NewtonsSquareCentimeter:
                    _value = value * 0.10197162129779;
                    break;

                case PressureTypes.NewtonsSquareMeter:
                    _value = value * 0.000010197162129779;
                    break;

                case PressureTypes.PSI:
                    _value = value * 0.070306957833135;
                    break;

                case PressureTypes.Pascals:
                    _value = value * 0.000010197162129779;
                    break;
            }
        }

        public double ToAtmospheres() => _value;

        public double ToBars() => _value * 1.01325;

        public double ToInchesMercury() => _value * 29.921331923765;

        public double ToKilogramsSquareCentimeter() => _value * 1.0332274527999;

        public double ToNewtonsSquareCentimeter() => _value * 10.1325;

        public double ToNewtonsSquareMeter() => _value * 101325;

        public double ToPascals() => _value * 101325;

        public double ToPsi() => _value * 14.69594880285;

        public List<string> UnitTypes()
        {
            return Enum.GetValues(typeof(PressureTypes)).Cast<string>().ToList();
        }

        #endregion Public Methods
    }
}