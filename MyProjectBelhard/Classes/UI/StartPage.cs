using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectBelhard.Classes.Model;

namespace MyProjectBelhard.Classes.UI
{
    internal class StartPage : CommonDecor
    {
        public StartPage()
        {
            GetHeader();
            GetStartMenu();
            SelectMenuItem();
        }

        void GetStartMenu()
        {
            Console.WriteLine("1. Log In");
            Console.WriteLine("2. Registration");
        }

        void SelectMenuItem()
        {
            bool b = Int32.TryParse(Console.ReadLine(), out int count);
            if (b & count == 1)
            {
                LogIn logIn = new LogIn();
            }
            else if(b & count == 2)
            {
                Registration registration = new Registration();
            }
            else
            {
                Console.WriteLine("Wrong menu selection.");
                SelectMenuItem();
            }
        }
    }
}
