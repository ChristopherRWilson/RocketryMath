// © 2017 Chris Wilson. All Rights Reserved
// Created: 04/14/2017 11:50 PM

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Units;

namespace UnitsUnitTest
{
    [TestClass]
    public class VelocityTest
    {
        #region Public Methods

        [TestMethod]
        public void TestFeetPerSecond()
        {
            var unit = new Velocity(100, VelocityTypes.FeetPerSecond);

            Assert.AreEqual(100, unit.ToFeetPerSecond(), 0.001);
            Assert.AreEqual(109.728, unit.ToKilometersPerHour(), 0.001);
            Assert.AreEqual(0.03048, unit.ToKilometersPerSecond(), 0.001);
            Assert.AreEqual(0.088863, unit.ToMach(), 0.001);
            Assert.AreEqual(109728, unit.ToMetersPerHour(), 0.001);
            Assert.AreEqual(30.48, unit.ToMetersPerSecond(), 0.001);
            Assert.AreEqual(68.1818182, unit.ToMilesPerHour(), 0.001);
        }

        [TestMethod]
        public void TestFeetPerSecondZero()
        {
            var unit = new Velocity(0, VelocityTypes.FeetPerSecond);

            Assert.AreEqual(0, unit.ToFeetPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToKilometersPerHour(), 0.001);
            Assert.AreEqual(0, unit.ToKilometersPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToMach(), 0.001);
            Assert.AreEqual(0, unit.ToMetersPerHour(), 0.001);
            Assert.AreEqual(0, unit.ToMetersPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToMilesPerHour(), 0.001);
        }

        [TestMethod]
        public void TestKilometersPerHour()
        {
            var unit = new Velocity(100, VelocityTypes.KilometersPerHour);

            Assert.AreEqual(91.1344415, unit.ToFeetPerSecond(), 0.001);
            Assert.AreEqual(100, unit.ToKilometersPerHour(), 0.001);
            Assert.AreEqual(0.0277778, unit.ToKilometersPerSecond(), 0.001);
            Assert.AreEqual(0.0809848, unit.ToMach(), 0.001);
            Assert.AreEqual(100000, unit.ToMetersPerHour(), 0.01);
            Assert.AreEqual(27.7777778, unit.ToMetersPerSecond(), 0.001);
            Assert.AreEqual(62.1371192, unit.ToMilesPerHour(), 0.001);
        }

        [TestMethod]
        public void TestKilometersPerHourZero()
        {
            var unit = new Velocity(0, VelocityTypes.KilometersPerHour);

            Assert.AreEqual(0, unit.ToFeetPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToKilometersPerHour(), 0.001);
            Assert.AreEqual(0, unit.ToKilometersPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToMach(), 0.001);
            Assert.AreEqual(0, unit.ToMetersPerHour(), 0.001);
            Assert.AreEqual(0, unit.ToMetersPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToMilesPerHour(), 0.001);
        }

        [TestMethod]
        public void TestKilometersPerSecond()
        {
            var unit = new Velocity(100, VelocityTypes.KilometersPerSecond);

            Assert.AreEqual(328084, unit.ToFeetPerSecond(), 0.001);
            Assert.AreEqual(360000, unit.ToKilometersPerHour(), 0.001);
            Assert.AreEqual(100, unit.ToKilometersPerSecond(), 0.001);
            Assert.AreEqual(291.54519, unit.ToMach(), 0.001);
            Assert.AreEqual(360000000, unit.ToMetersPerHour(), 0.001);
            Assert.AreEqual(100000, unit.ToMetersPerSecond(), 0.001);
            Assert.AreEqual(223694, unit.ToMilesPerHour(), 0.001);
        }

        [TestMethod]
        public void TestKilometersPerSecondZero()
        {
            var unit = new Velocity(0, VelocityTypes.KilometersPerSecond);

            Assert.AreEqual(0, unit.ToFeetPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToKilometersPerHour(), 0.001);
            Assert.AreEqual(0, unit.ToKilometersPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToMach(), 0.001);
            Assert.AreEqual(0, unit.ToMetersPerHour(), 0.001);
            Assert.AreEqual(0, unit.ToMetersPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToMilesPerHour(), 0.001);
        }

        [TestMethod]
        public void TestMach()
        {
            var unit = new Velocity(1, VelocityTypes.Mach);

            Assert.AreEqual(1125.33, unit.ToFeetPerSecond(), 0.01);
            Assert.AreEqual(1234.8, unit.ToKilometersPerHour(), 0.001);
            Assert.AreEqual(0.343, unit.ToKilometersPerSecond(), 0.001);
            Assert.AreEqual(1, unit.ToMach(), 0.001);
            Assert.AreEqual(1234800, unit.ToMetersPerHour(), 0.001);
            Assert.AreEqual(343, unit.ToMetersPerSecond(), 0.001);
            Assert.AreEqual(767.269, unit.ToMilesPerHour(), 0.01);
        }

        [TestMethod]
        public void TestMachZero()
        {
            var unit = new Velocity(0, VelocityTypes.Mach);

            Assert.AreEqual(0, unit.ToFeetPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToKilometersPerHour(), 0.001);
            Assert.AreEqual(0, unit.ToKilometersPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToMach(), 0.001);
            Assert.AreEqual(0, unit.ToMetersPerHour(), 0.001);
            Assert.AreEqual(0, unit.ToMetersPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToMilesPerHour(), 0.001);
        }

        [TestMethod]
        public void TestMetersPerHour()
        {
            var unit = new Velocity(100, VelocityTypes.MetersPerHour);

            Assert.AreEqual(0.0911344, unit.ToFeetPerSecond(), 0.001);
            Assert.AreEqual(0.1, unit.ToKilometersPerHour(), 0.001);
            Assert.AreEqual(0.0000278, unit.ToKilometersPerSecond(), 0.001);
            Assert.AreEqual(8.09848e-5, unit.ToMach(), 0.001);
            Assert.AreEqual(100, unit.ToMetersPerHour(), 0.01);
            Assert.AreEqual(0.0277778, unit.ToMetersPerSecond(), 0.001);
            Assert.AreEqual(0.0621371, unit.ToMilesPerHour(), 0.001);
        }

        [TestMethod]
        public void TestMetersPerHourZero()
        {
            var unit = new Velocity(0, VelocityTypes.MetersPerHour);

            Assert.AreEqual(0, unit.ToFeetPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToKilometersPerHour(), 0.001);
            Assert.AreEqual(0, unit.ToKilometersPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToMach(), 0.001);
            Assert.AreEqual(0, unit.ToMetersPerHour(), 0.001);
            Assert.AreEqual(0, unit.ToMetersPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToMilesPerHour(), 0.001);
        }

        [TestMethod]
        public void TestMetersPerSecond()
        {
            var unit = new Velocity(100, VelocityTypes.MetersPerSecond);

            Assert.AreEqual(328.0839895, unit.ToFeetPerSecond(), 0.001);
            Assert.AreEqual(360, unit.ToKilometersPerHour(), 0.001);
            Assert.AreEqual(0.1, unit.ToKilometersPerSecond(), 0.001);
            Assert.AreEqual(0.291545, unit.ToMach(), 0.001);
            Assert.AreEqual(360000, unit.ToMetersPerHour(), 0.001);
            Assert.AreEqual(100, unit.ToMetersPerSecond(), 0.001);
            Assert.AreEqual(223.6936292, unit.ToMilesPerHour(), 0.001);
        }

        [TestMethod]
        public void TestMetersPerSecondZero()
        {
            var unit = new Velocity(0, VelocityTypes.MetersPerSecond);

            Assert.AreEqual(0, unit.ToFeetPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToKilometersPerHour(), 0.001);
            Assert.AreEqual(0, unit.ToKilometersPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToMach(), 0.001);
            Assert.AreEqual(0, unit.ToMetersPerHour(), 0.001);
            Assert.AreEqual(0, unit.ToMetersPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToMilesPerHour(), 0.001);
        }

        [TestMethod]
        public void TestMilesPerHour()
        {
            var unit = new Velocity(100, VelocityTypes.MilesPerHour);

            Assert.AreEqual(146.6666667, unit.ToFeetPerSecond(), 0.001);
            Assert.AreEqual(160.9344, unit.ToKilometersPerHour(), 0.001);
            Assert.AreEqual(0.044704, unit.ToKilometersPerSecond(), 0.001);
            Assert.AreEqual(0.130332, unit.ToMach(), 0.001);
            Assert.AreEqual(160934.4, unit.ToMetersPerHour(), 0.001);
            Assert.AreEqual(44.704, unit.ToMetersPerSecond(), 0.001);
            Assert.AreEqual(100, unit.ToMilesPerHour(), 0.001);
        }

        [TestMethod]
        public void TestMilesPerHourZero()
        {
            var unit = new Velocity(0, VelocityTypes.MilesPerHour);

            Assert.AreEqual(0, unit.ToFeetPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToKilometersPerHour(), 0.001);
            Assert.AreEqual(0, unit.ToKilometersPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToMach(), 0.001);
            Assert.AreEqual(0, unit.ToMetersPerHour(), 0.001);
            Assert.AreEqual(0, unit.ToMetersPerSecond(), 0.001);
            Assert.AreEqual(0, unit.ToMilesPerHour(), 0.001);
        }

        #endregion Public Methods
    }
}