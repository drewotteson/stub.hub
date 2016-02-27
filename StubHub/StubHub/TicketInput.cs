using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubHub
{
    class TicketInput
    {
        public string eventCategory;
        public string eventDescription;
        public string eventDateTime;
        public string eventLocation;
        public string seatPrice;
        public string seatLocation;

        public string getTickCategory()
        {
            Console.WriteLine("game or concert?");
            eventCategory = Console.ReadLine();
            if (eventCategory == "game")
            {
                return eventCategory;
            }
            else if (eventCategory == "concert")
            {
                return eventCategory;
            }
            else
            {
                Console.WriteLine("invalid entry");
                getTickCategory();
            }
            return eventCategory;
        }

        public string getEventDiscription()
        {
            Console.WriteLine("provide the team(s) or artist");
            eventDescription = Console.ReadLine();
            return eventDescription;
        }

        public string getEventDateTime()
        {
            Console.WriteLine("when is the event taking place? (ex. fri:jan1:7:00pm)");
            eventDateTime = Console.ReadLine();
            return eventDateTime;
        }

        public string getEventLocation()
        {
            Console.WriteLine("where is the event? (ex. venue:city");
            eventLocation = Console.ReadLine();
            return eventLocation;
        }

        public string priceOfSeat()
        {
            Console.WriteLine("what is the price of the seat?");
            seatPrice = (Console.ReadLine());
            return seatPrice;
        }

        public string locationOfSeat()
        {
            Console.WriteLine("where is the seat located? (ex. section100:row10:seat1)");
            seatLocation = Console.ReadLine();
            return seatLocation;
        }

        public void createTicket()
        {
            Ticket newticket = new Ticket(eventCategory, eventDescription, eventDateTime, eventLocation, seatPrice, seatLocation);
        }
    }
}
