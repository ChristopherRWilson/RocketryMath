using Units;

namespace RocketryMath.Models
{
    public class Variable
    {
        #region Public Properties

        public string VariableDescription { get; set; }

        public string VariableName { get; set; }

        #endregion Public Properties

        public Unit Value { get; set; }

        public VariableTypes VariableType { get; set; }
    }
}