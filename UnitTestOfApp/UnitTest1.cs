using ATestWebApi.Controllers;
using NUnit.Framework;
using TestApplication;

namespace UnitTestOfApp
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var ts = new TestService();
            Assert.AreEqual(ts.DoSomething("sws", "sws"), "sws,sws");
        }

        [Test]
        public void Test2()
        {
            var ts = new WeatherForecastController();
            Assert.IsNotNull(ts.Get());
        }
    }
}