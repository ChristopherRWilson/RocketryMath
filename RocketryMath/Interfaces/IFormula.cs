using RocketryMath.Models;
using System.Collections.Generic;

namespace RocketryMath.Interfaces
{
    public interface IFormula
    {
        #region Public Methods

        string FormulaCategory();

        string FormulaDescription();

        string FormulaExplanation();

        string FormulaMarkup();

        string FormulaMarkupSolved();

        string FormulaName();

        string FormulaSource();

        string FormulaSourceUrl();

        List<string> FormulaTags();

        string Solve();

        List<Variable> Variables { get; set; }

        #endregion Public Methods
    }
}