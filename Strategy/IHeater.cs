using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// Общий интерфейс отопительных котлов
    /// </summary>
    interface IHeater
    {
        //  Нагрев
        void Heat();
    }
}
