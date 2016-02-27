using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubHub
{
    class Program
    {
        static void Main(string[] args)
        {
            HomePage homePage = new HomePage();
            List<List<string>> userList = new List<List<string>>();
            List<List<string>> ticketList = new List<List<string>>();
            homePage.signInOption();
            homePage.PopulateUserList();
            homePage.DisplayUserListContents(userList);
            Console.ReadLine();
            
        }
    }
}
