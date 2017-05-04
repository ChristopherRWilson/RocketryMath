using RocketryMath.Interfaces;
using System;
using System.Collections.Generic;
using Units;

namespace RocketryMath.Models.Formulas
{
    public class EjectionChargeCalculator : IFormula
    {
        #region Public Constructors

        public EjectionChargeCalculator()
        {
            Variables = new List<Variable>()
            {
                new Variable()
                {
                    VariableName = "C",
                    VariableDescription = "Grams of FFFF black powder required.",
                    VariableType = VariableTypes.Mass,
                    SolveFor = true
                },
                new Variable()
                {
                    VariableName = "d",
                    VariableDescription = "Diameter of rocket tube",
                    VariableType = VariableTypes.Distance
                },
                new Variable()
                {
                    VariableName = "l",
                    VariableDescription = "Length of rocket tube",
                    VariableType = VariableTypes.Distance
                },
                new Variable()
                {
                    VariableName = "p",
                    VariableDescription = "Desired pressure",
                    VariableType = VariableTypes.Pressure
                }
            };
        }

        #endregion Public Constructors



        #region Public Properties

        public List<Variable> Variables { get; set; }

        #endregion Public Properties



        #region Public Methods

        public string FormulaCategory()
        {
            throw new NotImplementedException();
        }

        public string FormulaDescription()
        {
            throw new NotImplementedException();
        }

        public string FormulaExplanation()
        {
            throw new NotImplementedException();
        }

        public string FormulaMarkup()
        {
            throw new NotImplementedException();
        }

        public string FormulaMarkupSolved()
        {
            throw new NotImplementedException();
        }

        public string FormulaName()
        {
            throw new NotImplementedException();
        }

        public string FormulaSource()
        {
            throw new NotImplementedException();
        }

        public string FormulaSourceUrl()
        {
            throw new NotImplementedException();
        }

        public List<string> FormulaTags()
        {
            throw new NotImplementedException();
        }

        public string Solve()
        {
            throw new NotImplementedException();
        }

        #endregion Public Methods
    }
}