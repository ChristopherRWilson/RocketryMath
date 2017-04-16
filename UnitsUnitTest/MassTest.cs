using Microsoft.VisualStudio.TestTools.UnitTesting;

using Units;

namespace UnitsUnitTest
{
    [TestClass]
    public class MassTest
    {
        #region Public Methods

        [TestMethod]
        public void TestGrams()
        {
            var unit = new Mass(100, MassTypes.Grams);
            Assert.AreEqual(100, unit.ToGrams(), .001);
            Assert.AreEqual(0.1, unit.ToKilograms(), .001);
            Assert.AreEqual(3.5274, unit.ToOunces(), .001);
            Assert.AreEqual(0.2204625002841, unit.ToPounds(), .001);
        }

        [TestMethod]
        public void TestKilograms()
        {
            var unit = new Mass(100, MassTypes.Kilograms);
            Assert.AreEqual(100000, unit.ToGrams(), .001);
            Assert.AreEqual(100, unit.ToKilograms(), .001);
            Assert.AreEqual(3527.4, unit.ToOunces(), .001);
            Assert.AreEqual(220.4625002841, unit.ToPounds(), .001);
        }

        [TestMethod]
        public void TestOunces()
        {
            var unit = new Mass(100, MassTypes.Ounces);
            Assert.AreEqual(2834.9500000294, unit.ToGrams(), .001);
            Assert.AreEqual(2.83495, unit.ToKilograms(), .001);
            Assert.AreEqual(100, unit.ToOunces(), .001);
            Assert.AreEqual(6.25, unit.ToPounds(), .001);
        }

        [TestMethod]
        public void TestPounds()
        {
            var unit = new Mass(100, MassTypes.Pounds);
            Assert.AreEqual(45359.2, unit.ToGrams(), .001);
            Assert.AreEqual(45.3592, unit.ToKilograms(), .001);
            Assert.AreEqual(1600, unit.ToOunces(), .001);
            Assert.AreEqual(100, unit.ToPounds(), .001);
        }

        #endregion Public Methods
    }
}