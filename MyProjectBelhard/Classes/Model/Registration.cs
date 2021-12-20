using MyProjectBelhard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectBelhard.Classes.Model
{
    internal class Registration
    {
        public Registration()
        {
            InputEmail();
            InputPassword();
            InputName();
            AddDataToDb();
        }

        private string email;
        private string password;
        private string name;

        void InputEmail()
        {
            Console.WriteLine("E-mail:");
            email = Console.ReadLine();
        }

        void InputPassword()
        {
            Console.WriteLine("Password:");
            password = Console.ReadLine();
        }

        void InputName()
        {
            Console.WriteLine("Name:");
            name = Console.ReadLine();
        }

        void AddDataToDb()
        {
            AppDbContext db = new AppDbContext();
            db.Users.Add(new User() { Email = email, Password = password, Name = name });
            db.SaveChanges();

            foreach(var user in db.Users)
            {
                Console.WriteLine($"{user.UserId}--{user.Email}--{user.Password}--{user.Name}");
            }
        }
    }
}
