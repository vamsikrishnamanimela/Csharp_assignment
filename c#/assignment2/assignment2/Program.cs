using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetassignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Reverse the string
            Console.WriteLine("******************Reverse String  program execution is start**********************");

            Console.WriteLine(" Enter  a string ");
            string Orginal = Console.ReadLine();
            string Reverse = string.Empty;

            for (int i = Orginal.Length - 1; i >= 0; i--)
            {
                Reverse += Orginal[i];
            }

            Console.WriteLine(" REVERESE STRING IS : " + Reverse);
            Console.WriteLine("******************Reverse the string program execution is End**********************");


            // Check the both words are same or not
            Console.WriteLine("******************Check the both words program execution is start**********************");
            Console.WriteLine(" Enter  The First Word......: ");
            string s1 = Console.ReadLine();
            Console.WriteLine(" Enter  The Second Word......: ");
            string s2 = Console.ReadLine();

            if (s1 == s2)
            {
                Console.WriteLine(" Both words are same ");
            }
            else if (s2 != s1)
            {
                Console.WriteLine(" Both words are  not same ");
            }
            Console.WriteLine("******************Check the both words program execution is End**********************");




            //1)Write a program given word  is  palindrome or not 


            Console.WriteLine("******************Palindrome  program execution is start**********************");
            string str2, rev;
            Console.WriteLine("Enter your word......: ");
            str2 = Console.ReadLine();
            char[] ch = str2.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool st = str2.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (st == true)
            {
                Console.WriteLine(" " + str2 + " The word is palindrome");
            }
            else if (st == false)
            {
                Console.WriteLine(" " + str2 + " The word is not palindrome ");
            }
            Console.WriteLine("******************Polindrom program execution is completed**********************");
            // 1) avarage of  maximum and minimum Numbers.
            Console.WriteLine("***********Avarage of  maximum and minimum  program execution is start**************");

            int[] Myarray = { 1, 2, 3, 4, 5 };
            Console.WriteLine(" The Avarage Element .......: {0}", Myarray.Average());
            Console.WriteLine(" The Largest Element......... :{0}", Myarray.Max());
            Console.WriteLine(" The Smallest Element.........:{0}", Myarray.Min());
            Console.WriteLine("******** Avarage of  maximum and minimum  program execution is End ***************");



            // 3) 10 marks avarage, maximum and minimum, sum of all marks,  ascending and descending order.
            Console.WriteLine("**** Marks Avarage   maximum and minimum ,sum  ascending and descending program execution is Start *****");
            int[] ak = { 10, 11, 15, 16, 19, 17, 18, 15, 16, 14 };

            Console.WriteLine(" The smallest element :" + " " + ak.Min());
            Console.WriteLine(" The largest element :" + " " + ak.Max());
            Console.WriteLine(" The avarage element :" + " " + ak.Average());
            Console.WriteLine("the sum of elements: " + ak.Sum());

            Array.Sort(ak);
            Console.WriteLine("array ascending order...");
            foreach (int i in ak)
            {
                Console.WriteLine(i + " ");
            }


            Array.Reverse(ak);
            Console.WriteLine("array decending order......");
            foreach (int i in ak)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("**** Marks Avarage   maximum and minimum ,sum  ascending and descending program execution is End *****");
            Console.ReadLine();

        }
    }
}
