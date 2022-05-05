using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodebasedTest1
{

    class PExpection : Exception
    {
        public PExpection(string msg) : base(msg)
        {

        }
    }
    class Passenger
    {
        int Age;
        string Name;
        string date_of_travel;
        int no_of_tickets;


        public Passenger(int age, string name, string date_of_travel)
        {
            this.Age = age;
            this.Name = name;
            this.date_of_travel = date_of_travel;

        }

        public void TicketBooking(int no_of_Tickets)

        {
            this.no_of_tickets = no_of_Tickets;
            Console.WriteLine($"The passenger details is Age {Age}, Name is {Name}, Date of travel is {dateoftravel}, no.of tickets is {no_of_Tickets}");
            Console.WriteLine(no_of_Tickets);
            
            if (no_of_Tickets > 5)
            {
                throw (new PassengerExpection("you Can not book more than 5 tickets"));
            }
            else
            {
                Console.WriteLine("Tickets booked successfully");
            }
        }
    }
    internal class TestClass
    {
        static void Main(string[] args)
        {

            Passenger pa = new Passenger(25, "vamsikrishna", "10/05/2022");

            try
            {
                pa.TicketBooking(6);
            }
            catch (PExpection ae)
            {
                Console.WriteLine(ae.Message);
            }

            Console.Read();
        }
    }
}