using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECSRefactor;

namespace ECSRefactorFake
{
    public class FakeHeater : IHeater
    {
        public void TurnOn()
        {
            System.Console.WriteLine("Heater is on");
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
}
