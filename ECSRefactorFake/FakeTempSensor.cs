using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECSRefactor;

namespace ECSRefactorFake
{
    public class FakeTempSensor : ITempSensor
    {
        public int GetTemp()
        {
            return 23;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
