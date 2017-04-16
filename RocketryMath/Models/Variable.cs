// © 2017 Chris Wilson. All Rights Reserved
// Created: 04/15/2017 7:08 PM

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