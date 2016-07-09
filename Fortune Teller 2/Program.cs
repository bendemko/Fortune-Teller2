using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read the user's first name from the user
            Console.WriteLine("What is your first name?: ");
            String firstName = Console.ReadLine();
            Console.Clear();
            //Read the user's last name from the user
            Console.WriteLine("What is your last name?: ");
            String lasttName = Console.ReadLine();
            Console.Clear();
            //Read the user's age from the user
            Console.WriteLine("What is your age?: ");
            string ageAsAString = Console.ReadLine();
            int age = Convert.ToInt32(ageAsAString);
            Console.Clear();
            //Read the user's birth month from the user
            Console.WriteLine("What is your birth month?: ");
            String birthMonth = Console.ReadLine();
            Console.Clear();
            //Read the user's favorite color from the user
            Console.WriteLine("What is your favorite ROYGBIV color?  If you don't know what a ROYGBIV color is, enter \"Help\": ");
            String favoriteColor = Console.ReadLine();
            //Read the number of siblings from the user
            Console.WriteLine("How many siblings do you have?: ");
            string numberOfSiblings = Console.ReadLine();
            int siblings = Convert.ToInt32(numberOfSiblings);
            Console.Clear();






            Console.ReadKey();

        }
    }
}
