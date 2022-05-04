
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentno6
{
    interface IStudent
    {
        void DisplayDetails(int Id, string Name);
    }
    class DaySholar : IStudent
    {
        public void DisplayDetails(int Id, string Name)
        {
            Console.WriteLine("Student id is.......:{0}", Id);
            Console.WriteLine("Name of the Student is.......:{0}", Name);
        }
    }
    class Resident : IStudent
    {
        public void DisplayDetails(int Id, string Name)
        {
            Console.WriteLine("Student id is.......:{0}", Id);
            Console.WriteLine("Name of the Student is.......:{0}",Name);
        }
    }
    class InterfaeEg
    {
        static void Main()
        {
            
            IStudent obj = new DaySholar();
            obj.DisplayDetails(1, "vamsikrishna");

            
            IStudent obj1 = new Resident();
            obj1.DisplayDetails(2, "Krishna vamsi");
            
Console.ReadLine();


        }
    }
}