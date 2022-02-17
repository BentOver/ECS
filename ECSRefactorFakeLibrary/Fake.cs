using ECSRefactor;

namespace ECSRefactorFakeLibrary
{
    public class FakeHeater : IHeater
    {
        public void TurnOn()
        {
            System.Console.WriteLine("Heater is on");
            ++Count;
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Heater is off");
        }

        public bool RunSelfTest()
        {
            return true;
        }

        public void ResetCount()
        {
            Count = 0;
        }

        public int Count
        {
            get;
            set;
        }
    }
    public class FakeTempSensor : ITempSensor
    {
        private int temp_;
        public int GetTemp()
        {
            return temp_;
        }

        public bool RunSelfTest()
        {
            return true;
        }

        public void SetTemp(int temp)
        {
            temp_ = temp;
        }

    }
}