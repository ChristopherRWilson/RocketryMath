using System;
using System.Collections.Generic;

using Units;

namespace RocketryMath.Models
{
    public class Variable
    {
        #region Public Properties

        public IEnumerable<string> AvailableUnits
        {
            get
            {
                switch (VariableType)
                {
                    case VariableTypes.Mass:
                        return Enum.GetNames(typeof(MassTypes));

                    case VariableTypes.Distance:
                        return Enum.GetNames(typeof(DistanceTypes));

                    case VariableTypes.Area:
                        return Enum.GetNames(typeof(AreaTypes));

                    case VariableTypes.Temperature:
                        return Enum.GetNames(typeof(TemperatureTypes));

                    case VariableTypes.Velocity:
                        return Enum.GetNames(typeof(VelocityTypes));

                    case VariableTypes.Volume:
                        return Enum.GetNames(typeof(VolumeTypes));

                    case VariableTypes.Pressure:
                        return Enum.GetNames(typeof(PressureTypes));
                }

                return null;
            }
        }

        public double Value { get; set; }

        public VariableTypes VariableType { get; set; }

        public string VariableUnit { get; set; }

        #endregion Public Properties



        #region Public Properties

        public bool SolveFor { get; set; }

        public string VariableDescription { get; set; }

        public string VariableName { get; set; }

        #endregion Public Properties
    }
}