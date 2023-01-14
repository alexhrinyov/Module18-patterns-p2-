using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Task_
{
    internal interface IAction
    {
        public void Run();
        public void Cancel();
    }
}
