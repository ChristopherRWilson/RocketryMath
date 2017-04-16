// © 2017 Chris Wilson. All Rights Reserved
// Created: 04/15/2017 8:20 PM

using RocketryMath.Interfaces;
using RocketryMath.Models.Formulas;
using System.Reflection;
using System.Web.Mvc;

namespace RocketryMath.Controllers
{
    public class FormulaController : Controller
    {
        #region Public Methods

        public ActionResult Explain(string Id)
        {
            var fullId = $"RocketryMath.Models.Formulas.{Id}";

            var formulaType = (IFormula)Assembly.GetExecutingAssembly().CreateInstance(fullId);
            if (formulaType == null)
                return new HttpNotFoundResult();

            var explanation = formulaType.FormulaExplanation();

            if (string.IsNullOrEmpty(explanation))
                explanation =
                    "<p>No explanation has been given for the math behind this formula yet.</p><p>If you would like to contribute an explanation, please <a href=\"https://github.com/ChristopherRWilson/RocketryMath\">contact us on GitHub</a>.</p>";

            ViewData.Add("SolveUrl", Url.Action("Solve", new { Id = Id }));
            ViewData.Add("TextExplanation", explanation);

            return View(formulaType);
        }

        public ActionResult Solve(string Id)
        {
            var fullId = $"RocketryMath.Models.Formulas.{Id}";
            var formulaType = (IFormula)Assembly.GetExecutingAssembly().CreateInstance(fullId);

            if (formulaType == null)
                return new HttpNotFoundResult();

            ViewData.Add("ExplainUrl", Url.Action("Explain", new { Id = Id }));

            return View(formulaType);
        }

        public ActionResult Solved(GhostParachuteSize formula)
        {
            return View("Solve", formula);
        }

        #endregion Public Methods
    }
}