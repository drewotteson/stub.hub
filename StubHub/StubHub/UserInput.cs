using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubHub
{
    public class UserInput
    {  
        public string userFirstName;
        public string userLastName;
        public string desiredUserName;
        public string desiredPassword;

        public string existingUsername;
        public string existingPassword;



        public string getFirstName()
        {
            Console.WriteLine("sign up: type your first name (enter)");
            userFirstName = Console.ReadLine();
            return userFirstName;
        }

        public string getLastName()
        {
            Console.WriteLine("type your last name (enter)");
            userLastName = Console.ReadLine();
            return userLastName;
        }

        public string getUsername()
        {
            Console.WriteLine("what would you like your username to be? (enter)");
            desiredUserName = Console.ReadLine();
            return desiredUserName;
        }

        public string getPassword()
        {
            Console.WriteLine("what would you like your password to be? (enter)");
            desiredPassword = Console.ReadLine();
            return desiredPassword;
        }

        public string enterUserName()
        {
            Console.WriteLine("enter your username");
            existingUsername = Console.ReadLine();
            return existingUsername;
        }

        public string enterPassWord()
        {
            Console.WriteLine("enter your password");
            existingPassword = Console.ReadLine();
            return existingPassword;

        }

        

        public void createUser()
        {
            User newuser = new User(userFirstName, userLastName, desiredUserName, desiredPassword);
        }

        

    }
}
