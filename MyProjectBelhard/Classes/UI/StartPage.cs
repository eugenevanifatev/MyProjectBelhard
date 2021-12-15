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
        }

        void GetStartMenu()
        {
            Console.WriteLine("1. Log In");
            LogIn logIn = new LogIn();

            Console.WriteLine("2. Registration");
        }
    }
}
