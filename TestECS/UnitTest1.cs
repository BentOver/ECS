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
            uut = new ECS(20);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}