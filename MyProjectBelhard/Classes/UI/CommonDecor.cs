using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectBelhard.Interfaces;

namespace MyProjectBelhard.Classes.UI
{
    internal class CommonDecor : ICommonDecorable
    {
        public void GetHeader()
        {
            string centerText = "Shop";
            int centerX = (Console.WindowWidth / 2) - (centerText.Length / 2);
            Console.SetCursorPosition(centerX, 0);
            Console.WriteLine(centerText);
            for(int i = 0; i < Console.WindowWidth; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.WriteLine("-");
            }
        }
    }
}
