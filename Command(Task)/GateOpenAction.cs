using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Task_
{
    internal class GateOpenAction : IAction
    {
        private Gate Gate;
        public GateOpenAction(Gate gate)
        {
            Gate = gate;
        }
        public void Cancel()
        {
            Gate.Close();
        }

        public void Run()
        {
            Gate.Open();
        }
    }
}
