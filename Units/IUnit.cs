using System.Collections.Generic;

namespace Units
{
    public interface IUnit
    {
        #region Public Methods

        string DefaultUnitType();

        double DefaultUnitValue();

        List<string> UnitTypes();

        #endregion Public Methods
    }
}