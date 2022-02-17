using NUnit.Framework;
using ECSRefactor;
using ECSRefactorFakeLibrary;

namespace TestECS
{
    public class Tests
    {
        private ECS uut;
        private FakeHeater heater = new FakeHeater();
        private FakeTempSensor ts = new FakeTempSensor();
        [SetUp]
        public void Setup()
        {
            heater.ResetCount();
            uut = new ECS(22, heater,ts);

        }

        [TestCase(20)]
        [TestCase(26)]
        [TestCase(17)]
        public void GetCurrentTemp(int temp)
        {
            ts.SetTemp(temp);
            Assert.That(uut.GetCurTemp(),Is.EqualTo(temp));
        }

        [TestCase(20)]
        [TestCase(26)]
        [TestCase(17)]
        public void GetThreshold(int threshold)
        {
            uut.SetThreshold(threshold);
            Assert.That(uut.GetThreshold(), Is.EqualTo(threshold));
        }

        [TestCase(20,1)]
        [TestCase(26,0)]
        [TestCase(17,1)]
        public void RegulateGetCount(int temp, int count)
        {
            heater.ResetCount();
            ts.SetTemp(temp);
            uut.Regulate();
            Assert.That(heater.Count, Is.EqualTo(count));

        }


    }
}