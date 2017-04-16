using Microsoft.VisualStudio.TestTools.UnitTesting;
using Units;

namespace UnitsUnitTest
{
    [TestClass]
    public class TemperatureTest
    {
        #region Public Methods

        [TestMethod]
        public void TestCelcius()
        {
            var unit = new Temperature(100, TemperatureTypes.Celcius);
            Assert.AreEqual(100, unit.ToCelcius(), 0.00001);
            Assert.AreEqual(212, unit.ToFarenheight(), 0.00001);
            Assert.AreEqual(373.15, unit.ToKelvin(), 0.00001);
        }

        [TestMethod]
        public void TestFarenheight()
        {
            var unit = new Temperature(32, TemperatureTypes.Farenheight);
            Assert.AreEqual(0, unit.ToCelcius(), 0.00001);
            Assert.AreEqual(32, unit.ToFarenheight(), 0.00001);
            Assert.AreEqual(273.15, unit.ToKelvin(), 0.00001);
        }

        [TestMethod]
        public void TestKelvin()
        {
            var unit = new Temperature(0, TemperatureTypes.Kelvin);
            Assert.AreEqual(-273.15, unit.ToCelcius(), 0.00001);
            Assert.AreEqual(-459.67, unit.ToFarenheight(), 0.00001);
            Assert.AreEqual(0, unit.ToKelvin(), 0.00001);
        }

        #endregion Public Methods
    }
}