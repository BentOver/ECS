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

            uut = new ECS(22, new Heater(), new TempSensor());
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}