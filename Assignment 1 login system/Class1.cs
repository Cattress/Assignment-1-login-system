using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_login_system
{
    class user
    {
        public string realName; //public == any can
        private string username; //private == other programs cannot access
        private string password;
        public bool loggedIn = false;

        public user(string un, string pw, string rln) //constructor
        {
            username = un;
            password = pw;
            realName = rln;
        }
        public bool checkLogin(string un, string pw) //function to check their username and password
        {
            if (un == username && pw == password)

            {

                loggedIn = true;
                return true;
            }
            else
            {
                return false;
            }
        }
           public void logOut()
        {
            loggedIn = false;
        
        }
        public void changePassword(string newPassword)
        {
            if(loggedIn == true)
            {
                Console.WriteLine("You have changed your password");
                password = newPassword;
            }
            else
            {
                Console.WriteLine("you are not logged in. cannot change password!");
            }
        }
    }
}
