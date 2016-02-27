using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubHub
{
    public class User
    {
        private string _FirstName;
        private string _LastName;
        private string _UserName;
        private string _PassWord;
        public string signInChoice;
        public string userTextFile = "users.txt";
        public string TicketOwner;
        UserInput ui = new UserInput();
        Ticket ticket = new Ticket();

        public User(string firstName, string lastName, string userName, string passWord)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
            this.PassWord = passWord;
        }

        public User()
        {

        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        public string PassWord
        {
            get { return _PassWord; }
            set { _PassWord = value; }
        }
    }
}
