// © 2017 Chris Wilson. All Rights Reserved
// Created: 04/15/2017 12:47 AM

using RocketryMath.Interfaces;
using System;
using System.Collections.Generic;
using Units;

namespace RocketryMath.Models.Formulas
{
    public class GhostParachuteSize : IFormula
    {
        #region Public Methods

        private List<Variable> workingVariables;

        public GhostParachuteSize()
        {
            workingVariables = Variables();
        }

        List<Variable> IFormula.VariableList
        {
            get { return workingVariables; }
            set { workingVariables = value; }
        }

        public string FormulaCategory()
        {
            return "Recovery>Drogue";
        }

        public string FormulaDescription()
        {
            return
                "<p>This calculates the equivalent size parachute that a rocket would have that would equal the cd of the rocket falling by iteself without a parachute.</p><p>This is useful for entering a drogue parachute size into simulation software, to simulate how fast the rocket would fall without a drogue.</p><p>For example, if you wish to create a simulation of a dual-deploy rocket, that will be a drogueless design you would use this formula to determine the parachute size to specify in the simulation so that it will simulate your rocket falling at the correct speed.</p>";
        }

        public string FormulaExplanation()
        {
            return string.Empty;
        }

        public string FormulaMarkup()
        {
            return @"D=\sqrt{\frac{4(L)(d)}{\pi}}";
        }

        public string FormulaMarkupSolved()
        {
            var answer = Solve();
            var diameter = Variables().Find(m => m.VariableName == "d").Value;
            var length = Variables().Find(m => m.VariableName == "L").Value;

            return $"{answer} = \\sqrt{{\\frac{{4({length})({diameter})}}{{\\pi}}}}";
        }

        public string FormulaName()
        {
            return "Ghost Parachute Size Calculator for Simulation";
        }

        public string FormulaSource()
        {
            return "Apogee Rockets Peak of Flight newsletter. Issue 361. March 25, 2014";
        }

        public string FormulaSourceUrl()
        {
            return "https://www.apogeerockets.com/education/downloads/Newsletter361.pdf";
        }

        public List<string> FormulaTags()
        {
            return new List<string>()
            {
                "Ejection",
                "Drogue",
                "Drogueless",
                "Simulation"
            };
        }

        public double Solve()
        {
            var diameter = Variables().Find(m => m.VariableName == "d").Value;
            var length = Variables().Find(m => m.VariableName == "L").Value;

            return Math.Sqrt((4 * length * diameter) / Math.PI);
        }

        public List<Variable> Variables()
        {
            return new List<Variable>()
            {
                new Variable()
                {
                    VariableName = "D",
                    VariableDescription = "Ghost drogue diameter",
                    VariableType = VariableTypes.Distance,
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
                    VariableName = "L",
                    VariableDescription = "Length of rocket tube",
                    VariableType = VariableTypes.Distance
                }
            };
        }

        #endregion Public Methods
    }
}