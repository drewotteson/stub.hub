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
        private string _EventCategory;
        private string _EventDescription;
        private string _EventDateTime;
        private string _EventLocation;
        private string _Price;
        private string _SeatLocation;
        public string ticketTextFile = "tickets.txt";
        List<string> tickDetails = new List<string>();
        TicketInput ti = new TicketInput();
        UserInput userInput = new UserInput();

        public Ticket(string eventCategory, string eventDescription, string eventDate, string eventLocation, string price, string seatLocation)
        {
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

        public void searchTicketCategory()
        {
            string choice = ti.getTickCategory();
            foreach (var line in File.ReadAllLines(ticketTextFile))
            {
                if (line.Contains(choice))
                {
                    Console.WriteLine(line);
                }             
            }
        }

        public void buyTicket()
        {

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
