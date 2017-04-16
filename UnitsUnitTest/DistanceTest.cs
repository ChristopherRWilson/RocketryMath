using Microsoft.VisualStudio.TestTools.UnitTesting;

using Units;

namespace UnitsUnitTest
{
    [TestClass]
    public class DistanceTest
    {
        #region Public Methods

        [TestMethod]
        public void TestCentimeters()
        {
            var unit = new Distance(100, DistanceTypes.Centimeters);
            Assert.AreEqual(1, unit.ToMeters(), 0.001);
            Assert.AreEqual(100, unit.ToCentimeters(), 0.001);
            Assert.AreEqual(3.28084, unit.ToFeet(), 0.001);
            Assert.AreEqual(39.3701, unit.ToInches(), 0.001);
            Assert.AreEqual(0.001, unit.ToKilometers(), 0.001);
            Assert.AreEqual(0.000621371, unit.ToMiles(), 0.001);
            Assert.AreEqual(1000, unit.ToMillimeters(), 0.001);
            Assert.AreEqual(1.09361, unit.ToYards(), 0.001);
        }

        [TestMethod]
        public void TestCentimetersZero()
        {
            var unit = new Distance(0, DistanceTypes.Centimeters);
            Assert.AreEqual(0, unit.ToMeters(), 0.001);
            Assert.AreEqual(0, unit.ToCentimeters(), 0.001);
            Assert.AreEqual(0, unit.ToFeet(), 0.001);
            Assert.AreEqual(0, unit.ToInches(), 0.001);
            Assert.AreEqual(0, unit.ToKilometers(), 0.001);
            Assert.AreEqual(0, unit.ToMiles(), 0.001);
            Assert.AreEqual(0, unit.ToMillimeters(), 0.001);
            Assert.AreEqual(0, unit.ToYards(), 0.001);
        }

        [TestMethod]
        public void TestFeet()
        {
            var unit = new Distance(100, DistanceTypes.Feet);
            Assert.AreEqual(30.48, unit.ToMeters(), 0.001);
            Assert.AreEqual(3048, unit.ToCentimeters(), 0.001);
            Assert.AreEqual(100, unit.ToFeet(), 0.001);
            Assert.AreEqual(1200, unit.ToInches(), 0.001);
            Assert.AreEqual(0.03048, unit.ToKilometers(), 0.001);
            Assert.AreEqual(0.0189394, unit.ToMiles(), 0.001);
            Assert.AreEqual(30480, unit.ToMillimeters(), 0.001);
            Assert.AreEqual(33.3333, unit.ToYards(), 0.001);
        }

        [TestMethod]
        public void TestFeetZero()
        {
            var unit = new Distance(0, DistanceTypes.Feet);
            Assert.AreEqual(0, unit.ToMeters(), 0.001);
            Assert.AreEqual(0, unit.ToCentimeters(), 0.001);
            Assert.AreEqual(0, unit.ToFeet(), 0.001);
            Assert.AreEqual(0, unit.ToInches(), 0.001);
            Assert.AreEqual(0, unit.ToKilometers(), 0.001);
            Assert.AreEqual(0, unit.ToMiles(), 0.001);
            Assert.AreEqual(0, unit.ToMillimeters(), 0.001);
            Assert.AreEqual(0, unit.ToYards(), 0.001);
        }

        [TestMethod]
        public void TestInches()
        {
            var unit = new Distance(100, DistanceTypes.Inches);
            Assert.AreEqual(2.54, unit.ToMeters(), 0.001);
            Assert.AreEqual(254, unit.ToCentimeters(), 0.001);
            Assert.AreEqual(8.33333, unit.ToFeet(), 0.001);
            Assert.AreEqual(100, unit.ToInches(), 0.001);
            Assert.AreEqual(0.00254, unit.ToKilometers(), 0.001);
            Assert.AreEqual(0.00157828, unit.ToMiles(), 0.001);
            Assert.AreEqual(2540, unit.ToMillimeters(), 0.001);
            Assert.AreEqual(2.77778, unit.ToYards(), 0.001);
        }

        [TestMethod]
        public void TestInchesZero()
        {
            var unit = new Distance(0, DistanceTypes.Inches);
            Assert.AreEqual(0, unit.ToMeters(), 0.001);
            Assert.AreEqual(0, unit.ToCentimeters(), 0.001);
            Assert.AreEqual(0, unit.ToFeet(), 0.001);
            Assert.AreEqual(0, unit.ToInches(), 0.001);
            Assert.AreEqual(0, unit.ToKilometers(), 0.001);
            Assert.AreEqual(0, unit.ToMiles(), 0.001);
            Assert.AreEqual(0, unit.ToMillimeters(), 0.001);
            Assert.AreEqual(0, unit.ToYards(), 0.001);
        }

        [TestMethod]
        public void TestKilometers()
        {
            var unit = new Distance(100, DistanceTypes.Kilometers);
            Assert.AreEqual(100000, unit.ToMeters(), 0.001);
            Assert.AreEqual(10000000, unit.ToCentimeters(), 0.001);
            Assert.AreEqual(328084, unit.ToFeet(), 0.001);
            Assert.AreEqual(3937010, unit.ToInches(), 0.001);
            Assert.AreEqual(100, unit.ToKilometers(), 0.001);
            Assert.AreEqual(62.1371, unit.ToMiles(), 0.001);
            Assert.AreEqual(1e+8, unit.ToMillimeters(), 0.001);
            Assert.AreEqual(109361, unit.ToYards(), 0.001);
        }

        [TestMethod]
        public void TestKilometersZero()
        {
            var unit = new Distance(0, DistanceTypes.Kilometers);
            Assert.AreEqual(0, unit.ToMeters(), 0.001);
            Assert.AreEqual(0, unit.ToCentimeters(), 0.001);
            Assert.AreEqual(0, unit.ToFeet(), 0.001);
            Assert.AreEqual(0, unit.ToInches(), 0.001);
            Assert.AreEqual(0, unit.ToKilometers(), 0.001);
            Assert.AreEqual(0, unit.ToMiles(), 0.001);
            Assert.AreEqual(0, unit.ToMillimeters(), 0.001);
            Assert.AreEqual(0, unit.ToYards(), 0.001);
        }

        [TestMethod]
        public void TestMeters()
        {
            var unit = new Distance(100, DistanceTypes.Meters);
            Assert.AreEqual(100, unit.ToMeters(), 0.001);
            Assert.AreEqual(10000, unit.ToCentimeters(), 0.001);
            Assert.AreEqual(328.084, unit.ToFeet(), 0.001);
            Assert.AreEqual(3937.01, unit.ToInches(), 0.001);
            Assert.AreEqual(0.1, unit.ToKilometers(), 0.001);
            Assert.AreEqual(0.0621371, unit.ToMiles(), 0.001);
            Assert.AreEqual(100000, unit.ToMillimeters(), 0.001);
            Assert.AreEqual(109.361, unit.ToYards(), 0.001);
        }

        [TestMethod]
        public void TestMetersZero()
        {
            var unit = new Distance(0, DistanceTypes.Meters);
            Assert.AreEqual(0, unit.ToMeters(), 0.001);
            Assert.AreEqual(0, unit.ToCentimeters(), 0.001);
            Assert.AreEqual(0, unit.ToFeet(), 0.001);
            Assert.AreEqual(0, unit.ToInches(), 0.001);
            Assert.AreEqual(0, unit.ToKilometers(), 0.001);
            Assert.AreEqual(0, unit.ToMiles(), 0.001);
            Assert.AreEqual(0, unit.ToMillimeters(), 0.001);
            Assert.AreEqual(0, unit.ToYards(), 0.001);
        }

        [TestMethod]
        public void TestMiles()
        {
            var unit = new Distance(100, DistanceTypes.Miles);
            Assert.AreEqual(160934, unit.ToMeters(), 0.5);
            Assert.AreEqual(16093400, unit.ToCentimeters(), 50);
            Assert.AreEqual(528000, unit.ToFeet(), 2);
            Assert.AreEqual(6336000, unit.ToInches(), 15);
            Assert.AreEqual(160.934, unit.ToKilometers(), 0.001);
            Assert.AreEqual(100, unit.ToMiles(), 0.001);
            Assert.AreEqual(160934000, unit.ToMillimeters(), 500);
            Assert.AreEqual(176000, unit.ToYards(), 0.6);
        }

        [TestMethod]
        public void TestMilesZero()
        {
            var unit = new Distance(0, DistanceTypes.Miles);
            Assert.AreEqual(0, unit.ToMeters(), 0.001);
            Assert.AreEqual(0, unit.ToCentimeters(), 0.001);
            Assert.AreEqual(0, unit.ToFeet(), 0.001);
            Assert.AreEqual(0, unit.ToInches(), 0.001);
            Assert.AreEqual(0, unit.ToKilometers(), 0.001);
            Assert.AreEqual(0, unit.ToMiles(), 0.001);
            Assert.AreEqual(0, unit.ToMillimeters(), 0.001);
            Assert.AreEqual(0, unit.ToYards(), 0.001);
        }

        [TestMethod]
        public void TestMillimeters()
        {
            var unit = new Distance(100, DistanceTypes.Millimeters);
            Assert.AreEqual(0.1, unit.ToMeters(), 0.001);
            Assert.AreEqual(10, unit.ToCentimeters(), 0.001);
            Assert.AreEqual(0.328084, unit.ToFeet(), 0.001);
            Assert.AreEqual(3.93701, unit.ToInches(), 0.001);
            Assert.AreEqual(1e-4, unit.ToKilometers(), 0.001);
            Assert.AreEqual(6.2137e-5, unit.ToMiles(), 0.001);
            Assert.AreEqual(100, unit.ToMillimeters(), 0.001);
            Assert.AreEqual(0.1093611199694, unit.ToYards(), 0.001);
        }

        [TestMethod]
        public void TestMillimetersZero()
        {
            var unit = new Distance(0, DistanceTypes.Millimeters);
            Assert.AreEqual(0, unit.ToMeters(), 0.001);
            Assert.AreEqual(0, unit.ToCentimeters(), 0.001);
            Assert.AreEqual(0, unit.ToFeet(), 0.001);
            Assert.AreEqual(0, unit.ToInches(), 0.001);
            Assert.AreEqual(0, unit.ToKilometers(), 0.001);
            Assert.AreEqual(0, unit.ToMiles(), 0.001);
            Assert.AreEqual(0, unit.ToMillimeters(), 0.001);
            Assert.AreEqual(0, unit.ToYards(), 0.001);
        }

        [TestMethod]
        public void TestYards()
        {
            var unit = new Distance(100, DistanceTypes.Yards);
            Assert.AreEqual(91.44, unit.ToMeters(), 0.001);
            Assert.AreEqual(9144, unit.ToCentimeters(), 0.001);
            Assert.AreEqual(300, unit.ToFeet(), 0.001);
            Assert.AreEqual(3600, unit.ToInches(), 0.002);
            Assert.AreEqual(0.09144, unit.ToKilometers(), 0.001);
            Assert.AreEqual(0.0568182, unit.ToMiles(), 0.001);
            Assert.AreEqual(91440, unit.ToMillimeters(), 0.001);
            Assert.AreEqual(100, unit.ToYards(), 0.001);
        }

        [TestMethod]
        public void TestYardsZero()
        {
            var unit = new Distance(0, DistanceTypes.Yards);
            Assert.AreEqual(0, unit.ToMeters(), 0.001);
            Assert.AreEqual(0, unit.ToCentimeters(), 0.001);
            Assert.AreEqual(0, unit.ToFeet(), 0.001);
            Assert.AreEqual(0, unit.ToInches(), 0.001);
            Assert.AreEqual(0, unit.ToKilometers(), 0.001);
            Assert.AreEqual(0, unit.ToMiles(), 0.001);
            Assert.AreEqual(0, unit.ToMillimeters(), 0.001);
            Assert.AreEqual(0, unit.ToYards(), 0.001);
        }

        #endregion Public Methods
    }
}