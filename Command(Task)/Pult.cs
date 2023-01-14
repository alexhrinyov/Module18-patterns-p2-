using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Task_
{
    internal class Pult
    {

        IAction Action;
        int BlinkState { get; set; }

        public void SetAction(IAction action)
        {
            Action = action;
        }

        // Выполнить
        public void OpenButton()
        {
          
            Action.Run();
        }

        // Отменить
        public void CloseButton()
        {
            Action.Cancel();
        }

        public void BlinkOnButton()
        {
            if (BlinkState == 0)
            {
                Action.Run();
                BlinkState = 1;
            }
            else
            {
                Action.Cancel();
                BlinkState = default(int);
            }
            
        }

        
        
        
    }
}
