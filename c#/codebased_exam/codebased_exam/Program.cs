using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodebasedTest1
{

    class PassengerExpection : Exception
    {
        public PassengerExpection(string msg) : base(msg)
        {

        }
    }
    class Passenger
    {
        int Age;
        string Name;
        string dateoftravel;
        int no_of_tickets;


        public Passenger(int age, string name, string date_travel)
        {
            this.Age = age;
            this.Name = name;
            this.dateoftravel = date_travel;

        }

        public void TicketBooking(int no_of_Tickets)

        {
            this.no_of_tickets = no_of_Tickets;
            Console.WriteLine(no_of_Tickets);
            
            if (no_of_Tickets > 5)
            {
                throw (new PassengerExpection("Can not book more than 5 tickets"));
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

            Passenger ps = new Passenger(20, "vamsikrishna", "10/05/2022");

            try
            {
                ps.TicketBooking(6);
            }
            catch (PassengerExpection ae)
            {
                Console.WriteLine(ae.Message);
            }

            Console.Read();
        }
    }
}