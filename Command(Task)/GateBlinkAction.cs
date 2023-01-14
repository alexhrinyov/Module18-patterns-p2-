using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Task_
{
    internal class GateBlinkAction : IAction
    {
        private Gate Gate;
        public GateBlinkAction(Gate gate)
        {
            Gate = gate;
        }
        public void Cancel()
        {
            Gate.StopBlink();
        }

        public void Run()
        {
            Gate.Blink();
        }
    }
}
