using System;

namespace ECSRefactor
{
    public interface ITempSensor
    {
        int GetTemp();
        bool RunSelfTest();
    }
}