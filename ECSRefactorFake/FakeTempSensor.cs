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
