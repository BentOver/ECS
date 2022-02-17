using NUnit.Framework;
using ECSRefactor;

namespace TestECS
{
    public class Tests
    {
        private ECS uut;
        [SetUp]
        public void Setup()
        {

            uut = new ECS(20, new Heater(), new TempSensor());
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}