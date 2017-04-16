using RocketryMath.Models;
using System.Collections.Generic;

namespace RocketryMath.Interfaces
{
    public interface IFormula
    {
        #region Public Methods

        string FormulaCategory();

        string FormulaDescription();

        string FormulaMarkup();

        string FormulaMarkupSolved();

        string FormulaName();

        string FormulaSource();

        string FormulaSourceUrl();

        List<string> FormulaTags();

        double Solve();

        List<Variable> Variables();

        #endregion Public Methods
    }
}