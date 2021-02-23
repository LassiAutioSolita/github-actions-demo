using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTests
{
    [TestClass, TestCategory("integration")]
    public class WeatherForecastIntegrationTests
    {
        [TestMethod]
        public async Task Retruns_HttpStatus_OK()
        {
            var sut = new HttpClient();
            var response = await sut.GetAsync("http://localhost:52081/weatherforecast");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
