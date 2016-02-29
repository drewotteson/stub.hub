using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StubHub
{
    public class Ticket
    {
        public string TicketOwner;
        private string _TicketNumber;
        private string _EventCategory;
        private string _EventDescription;
        private string _EventDateTime;
        private string _EventLocation;
        private string _Price;
        private string _SeatLocation;
        public string ticketTextFile = "tickets.txt";
        public string printedTicket = "printedTicket.txt";
        List<string> tickDetails = new List<string>();
        TicketInput ti = new TicketInput();
        UserInput userInput = new UserInput();

        public Ticket(string ticketNumber, string eventCategory, string eventDescription, string eventDate, string eventLocation, string price, string seatLocation)
        {
            this.TicketNumber = ticketNumber;
            this.EventCategory = eventCategory;
            this.EventDescription = eventDescription;
            this.EventDate = eventDate;
            this.EventLocation = eventLocation;
            this.Price = price;
            this.SeatLocation = seatLocation;
        }

        public Ticket()
        {
        }

        public void createAndPostTicket()
        {
            TicketOwner = userInput.enterUserName();
            tickDetails.Add(TicketOwner);

            TicketNumber = ti.getTicketNumber();
            tickDetails.Add(TicketNumber);

            EventCategory = ti.getTickCategory();
            tickDetails.Add(EventCategory);

            EventDescription = ti.getEventDiscription();
            tickDetails.Add(EventDescription);

            EventDate = ti.getEventDateTime();
            tickDetails.Add(EventDate);

            EventLocation = ti.getEventLocation();
            tickDetails.Add(EventLocation);

            Price = ti.priceOfSeat();
            tickDetails.Add(Price);

            SeatLocation = ti.locationOfSeat();
            tickDetails.Add(SeatLocation);

            Console.WriteLine("ticket successfully created");
            populateTicketList();
        }

        public void populateTicketList()
        {
            List<List<string>> tickList = new List<List<string>>();
            for (int i = 0; i < 1; i++)
            {
                tickList.Add(tickDetails);
            }
            displayTickListContents(tickList);
        }

        public void displayTickListContents(List<List<string>> tickList)
        {
            foreach (var tickContents in tickList)
            {
                string tick = "";
                foreach (var tickDetail in tickDetails)
                {
                    tick += tickDetail + ",";
                }
                File.AppendAllText(ticketTextFile, tick + Environment.NewLine);
                //parentlist.Add(new List<string>() { "asdfasdf", name})                
            }
        }

        public void searchAllTicketCategories()
        {
            string choice = ti.getTickCategory();
            foreach (string line in File.ReadAllLines(ticketTextFile))
            {
                if (line.Contains(choice))
                {
                    Console.WriteLine(line);
                }             
            }
        }

        public void displayUserTickets()
        {
            string checkUserName = userInput.enterUserName();
            foreach (string myTickets in File.ReadAllLines(ticketTextFile))
            {
                if (myTickets.Contains(checkUserName))
                {
                    Console.WriteLine(myTickets);
                }
            }
        }

        public void chooseTicketToBuy()
        {
            string ticketChoice = ti.getTicketNumber();
            foreach (string ticket in File.ReadAllLines(ticketTextFile))
            {
                if (ticket.Contains(ticketChoice))
                {
                    string[] splitFormat = ticket.Split(',');
                    string ticketFormat = String.Format("user: {0}ticket number: {1}category {2}description: {3}date: {4}event location:{5}price: {6}seat location: {7}", splitFormat[0] + Environment.NewLine, splitFormat[1] + Environment.NewLine, splitFormat[2] + Environment.NewLine, splitFormat[3] + Environment.NewLine, splitFormat[4] + Environment.NewLine, splitFormat[5] + Environment.NewLine, splitFormat[6] + Environment.NewLine, splitFormat[7] + Environment.NewLine);
                    File.AppendAllText(printedTicket, ticketFormat);
                    Console.WriteLine("ticket successfully purchased");
                }
            }
        }
        
        public string TicketNumber
        {
            get { return _TicketNumber; }
            set { _TicketNumber = value; }
        }

        public string EventCategory
        {
            get { return _EventCategory; }
            set { _EventCategory = value; }
        }

        public string EventDescription
        {
            get { return _EventDescription; }
            set { _EventDescription = value; }
        }

        public string EventDate
        {
            get { return _EventDateTime; }
            set { _EventDateTime = value; }
        }

        public string EventLocation
        {
            get { return _EventLocation; }
            set { _EventLocation = value; }
        }

        public string Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public string SeatLocation
        {
            get { return _SeatLocation; }
            set { _SeatLocation = value; }
        }
    }
}
