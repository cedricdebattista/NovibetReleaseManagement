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
    }
}