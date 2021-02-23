using AzDevOpsDemoWebApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AzDevOpsDemoWebApplicationUnitTests
{
    [TestClass, TestCategory("unit")]
    public class WeatherForecastTests
    {
        [TestMethod]
        public void TemperatureFTest()
        {
            var sut = new WeatherForecast();
            sut.TemperatureC = 38;
            Assert.AreEqual(100, sut.TemperatureF);
        }
    }
}
