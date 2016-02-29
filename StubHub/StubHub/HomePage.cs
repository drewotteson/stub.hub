using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubHub
{
    public class HomePage
    {
        User user = new User();
        Ticket ticket = new Ticket();
        UserInput userInput = new UserInput();
        FileWrite fw = new FileWrite();
        List<string> userDetails = new List<string>();
  
        public string signInChoice;

        public void signInOption()
        {
            Console.WriteLine("choose: log in or sign up");
            signInChoice = Console.ReadLine();
            if (signInChoice == "log in")
            {
                string userNameInput = userInput.enterUserName();
                string passwordInput = userInput.enterPassWord();
                foreach (var line in File.ReadAllLines(user.userTextFile))
                {
                    if (line.Contains(userNameInput))
                    {
                        if (line.Contains(passwordInput))
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome: "+ userNameInput);
                            userChooseTask();
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry, please try again");
                        signInOption();
                    }
                }
            }

            else if (signInChoice == "sign up")
            {
                string firstName = userInput.getFirstName();
                user.FirstName = firstName;
                userDetails.Add(firstName);

                string lastName = userInput.getLastName();
                user.LastName = lastName;
                userDetails.Add(lastName);

                string userName = userInput.getUsername();
                user.UserName = userName;
                userDetails.Add(userName);

                string userPassword = userInput.getPassword();
                user.PassWord = userPassword;
                userDetails.Add(userPassword);

                Console.Clear();
                Console.WriteLine("account successfully created");
                PopulateUserList();
            }
            else
            {
                Console.WriteLine("invalid entry");
                signInOption();
            }
        }

        public void PopulateUserList()
        {
            List<List<string>> userList = new List<List<string>>();
            for (int i = 0; i < 1; i++)
            {
                userList.Add(userDetails);
            }
            DisplayUserListContents(userList);
        }

        public void DisplayUserListContents(List<List<string>> userList)
        {
            foreach (var userDetails in userList)
            {
                string _user = "";
                foreach (var detail in userDetails)
                {                  
                    _user += detail + ",";                  
                }
                File.AppendAllText(user.userTextFile, _user);
                userChooseTask();
            }
        }

        public void userChooseTask()
        {
            Console.WriteLine("choose: post ticket to sell(post), buy ticket(buy), search by category(search), display my tickets(display), leave the site(leave)");
            string input = Console.ReadLine();

            switch (input)
            {
                case "post":
                    ticket.createAndPostTicket();
                    break;
                case "buy":
                    ticket.chooseTicketToBuy();
                    break;
                case "search":
                    ticket.searchAllTicketCategories();
                    break;
                case "display":
                    ticket.displayUserTickets();
                    break;
                case "leave":
                    break;
                default:
                    break;
            }
        }
    }
}
