using System;

namespace Assignment_1_login_system
{
    class Program
    {
        static void Main(string[] args)
        {
            user bobby = new user("bob","bob123","Bob Smith");
            Console.WriteLine("User Logged in: "+bobby.loggedIn);

            Console.Write(bobby.checkLogin("Adam", "adam123"));
            Console.Write(bobby.checkLogin("Adam", "bob123"));
            Console.Write(bobby.checkLogin("bob", "bob123"));

            Console.WriteLine("User Logged in: " + bobby.loggedIn);


            Console.WriteLine(bobby.realName);

            bobby.logOut();
            bobby.changePassword("brown123");
            Console.WriteLine("user logged in: " + bobby.loggedIn);
        }
    }
}
