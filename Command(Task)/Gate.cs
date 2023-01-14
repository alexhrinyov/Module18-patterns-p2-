using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Task_
{
    internal class Gate
    {
        public void Open()
        {
            Console.WriteLine("Открываем ворота");
        }

        public void Close()
        {
            Console.WriteLine("Закрываем ворота");
        }

        public void Blink()
        {
            Console.WriteLine("Лампа на воротах мигает");
        }
        public void StopBlink()
        {
            Console.WriteLine("Лампа на воротах перестаёт мигать");
        }
    }
}
