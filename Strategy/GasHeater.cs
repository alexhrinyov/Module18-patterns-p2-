using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    ///  Реализация газового отопления
    /// </summary>
    class GasHeater : IHeater
    {
        public void Heat()
        {
            Console.WriteLine("Нагрев газом");
        }
    }
}
