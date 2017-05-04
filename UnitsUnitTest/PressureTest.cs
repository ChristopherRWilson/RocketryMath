using Microsoft.VisualStudio.TestTools.UnitTesting;

using Units;

namespace UnitsUnitTest
{
    [TestClass]
    public class PressureTest
    {
        #region Public Methods

        [TestMethod]
        public void TestAtmospheres()
        {
            var unit = new Pressure(100, PressureTypes.Atmospheres);

            Assert.AreEqual(100, unit.ToAtmospheres(), 4);
            Assert.AreEqual(101.325, unit.ToBars(), 4);
            Assert.AreEqual(2992.1331923765, unit.ToInchesMercury(), 100);
            Assert.AreEqual(103.32274527999, unit.ToKilogramsSquareCentimeter(), 4);
            Assert.AreEqual(1013.25, unit.ToNewtonsSquareCentimeter(), 35);
            Assert.AreEqual(10132500, unit.ToNewtonsSquareMeter(), 337000);
            Assert.AreEqual(10132500, unit.ToPascals(), 337000);
            Assert.AreEqual(1469.594880285, unit.ToPsi(), 50);
        }

        [TestMethod]
        public void TestBars()
        {
            var unit = new Pressure(100, PressureTypes.Atmospheres);

            Assert.AreEqual(0, unit.ToAtmospheres(), 4);
            Assert.AreEqual(0, unit.ToBars(), 4);
            Assert.AreEqual(0, unit.ToInchesMercury(), 100);
            Assert.AreEqual(0, unit.ToKilogramsSquareCentimeter(), 4);
            Assert.AreEqual(0, unit.ToNewtonsSquareCentimeter(), 35);
            Assert.AreEqual(0, unit.ToNewtonsSquareMeter(), 337000);
            Assert.AreEqual(0, unit.ToPascals(), 337000);
            Assert.AreEqual(0, unit.ToPsi(), 50);
        }

        [TestMethod]
        public void TestInchesMercury()
        {
            var unit = new Pressure(100, PressureTypes.Atmospheres);

            Assert.AreEqual(0, unit.ToAtmospheres(), 4);
            Assert.AreEqual(0, unit.ToBars(), 4);
            Assert.AreEqual(0, unit.ToInchesMercury(), 100);
            Assert.AreEqual(0, unit.ToKilogramsSquareCentimeter(), 4);
            Assert.AreEqual(0, unit.ToNewtonsSquareCentimeter(), 35);
            Assert.AreEqual(0, unit.ToNewtonsSquareMeter(), 337000);
            Assert.AreEqual(0, unit.ToPascals(), 337000);
            Assert.AreEqual(0, unit.ToPsi(), 50);
        }

        [TestMethod]
        public void TestKilogramsSquareCentimeter()
        {
            var unit = new Pressure(100, PressureTypes.Atmospheres);

            Assert.AreEqual(0, unit.ToAtmospheres(), 4);
            Assert.AreEqual(0, unit.ToBars(), 4);
            Assert.AreEqual(0, unit.ToInchesMercury(), 100);
            Assert.AreEqual(0, unit.ToKilogramsSquareCentimeter(), 4);
            Assert.AreEqual(0, unit.ToNewtonsSquareCentimeter(), 35);
            Assert.AreEqual(0, unit.ToNewtonsSquareMeter(), 337000);
            Assert.AreEqual(0, unit.ToPascals(), 337000);
            Assert.AreEqual(0, unit.ToPsi(), 50);
        }

        [TestMethod]
        public void TestNewtonsSquareCentimeter()
        {
            var unit = new Pressure(100, PressureTypes.Atmospheres);

            Assert.AreEqual(0, unit.ToAtmospheres(), 4);
            Assert.AreEqual(0, unit.ToBars(), 4);
            Assert.AreEqual(0, unit.ToInchesMercury(), 100);
            Assert.AreEqual(0, unit.ToKilogramsSquareCentimeter(), 4);
            Assert.AreEqual(0, unit.ToNewtonsSquareCentimeter(), 35);
            Assert.AreEqual(0, unit.ToNewtonsSquareMeter(), 337000);
            Assert.AreEqual(0, unit.ToPascals(), 337000);
            Assert.AreEqual(0, unit.ToPsi(), 50);
        }

        [TestMethod]
        public void TestNewtonsSquareMeter()
        {
            var unit = new Pressure(100, PressureTypes.Atmospheres);

            Assert.AreEqual(0, unit.ToAtmospheres(), 4);
            Assert.AreEqual(0, unit.ToBars(), 4);
            Assert.AreEqual(0, unit.ToInchesMercury(), 100);
            Assert.AreEqual(0, unit.ToKilogramsSquareCentimeter(), 4);
            Assert.AreEqual(0, unit.ToNewtonsSquareCentimeter(), 35);
            Assert.AreEqual(0, unit.ToNewtonsSquareMeter(), 337000);
            Assert.AreEqual(0, unit.ToPascals(), 337000);
            Assert.AreEqual(0, unit.ToPsi(), 50);
        }

        [TestMethod]
        public void TestPascals()
        {
            var unit = new Pressure(100, PressureTypes.Atmospheres);

            Assert.AreEqual(0, unit.ToAtmospheres(), 4);
            Assert.AreEqual(0, unit.ToBars(), 4);
            Assert.AreEqual(0, unit.ToInchesMercury(), 100);
            Assert.AreEqual(0, unit.ToKilogramsSquareCentimeter(), 4);
            Assert.AreEqual(0, unit.ToNewtonsSquareCentimeter(), 35);
            Assert.AreEqual(0, unit.ToNewtonsSquareMeter(), 337000);
            Assert.AreEqual(0, unit.ToPascals(), 337000);
            Assert.AreEqual(0, unit.ToPsi(), 50);
        }

        [TestMethod]
        public void TestPsi()
        {
            var unit = new Pressure(100, PressureTypes.Atmospheres);

            Assert.AreEqual(0, unit.ToAtmospheres(), 4);
            Assert.AreEqual(0, unit.ToBars(), 4);
            Assert.AreEqual(0, unit.ToInchesMercury(), 100);
            Assert.AreEqual(0, unit.ToKilogramsSquareCentimeter(), 4);
            Assert.AreEqual(0, unit.ToNewtonsSquareCentimeter(), 35);
            Assert.AreEqual(0, unit.ToNewtonsSquareMeter(), 337000);
            Assert.AreEqual(0, unit.ToPascals(), 337000);
            Assert.AreEqual(0, unit.ToPsi(), 50);
        }

        #endregion Public Methods
    }
}