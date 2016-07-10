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
            while(true)

            { 

            //Ask and read the user's first name
            Console.WriteLine("What is your first name?: ");
            String firstName = Console.ReadLine();
            Console.Clear();
            
            //Ask abd read the user's last name
            Console.WriteLine("What is your last name?: ");
            String lastName = Console.ReadLine();
            Console.Clear();

             //Ask and read the user's age
            Console.WriteLine("What is your age?: ");
            string ageAsAString = Console.ReadLine();
            double yearsToRetirement = Convert.ToDouble(ageAsAString);
            Console.Clear();

            //Ask and read the user's birth month
            Console.WriteLine("What is your birth month?: ");
            String birthMonth = Console.ReadLine();
            Console.Clear();

            //Ask and read the user's favorite color
            Console.WriteLine("What is your favorite ROYGBIV color?  If you don't know what a ROYGBIV color is, enter \"Help\": ");
            string favoriteColor = Console.ReadLine();
           
         
         
            while (favoriteColor == "Help")
            
            {
                Console.WriteLine("A ROYGBIV color includes Red, Orange, Yellow, Green, Blue, Indigo and Violet.  Which do you choose?: ");
                favoriteColor = Console.ReadLine();
            }
            Console.Clear();

             //Ask and read the number of siblings the user has
             Console.WriteLine("How many siblings do you have?: ");
             string numberOfSiblings = Console.ReadLine();
             Console.Clear();

                //This determines the user's time to retirement            
                if (yearsToRetirement % 2 == 1)
                yearsToRetirement = 7;
                else if (yearsToRetirement % 2 == 0)
                yearsToRetirement = 31.5;

            //This determines where the user will live
                if (numberOfSiblings == "0")
                numberOfSiblings = "Belize";
                else if (numberOfSiblings == "1")
                numberOfSiblings = "Outer Siberia";
                if (numberOfSiblings == "2")
                numberOfSiblings = "North Korea";
                else if (numberOfSiblings == "3")
                numberOfSiblings = "Costa Rica";
                else
                numberOfSiblings = "Italy";

            //This determines the user's mode of transport
            if (favoriteColor.ToUpper() == "RED")
                favoriteColor = "Ferrari";
            else if (favoriteColor.ToUpper() == "ORANGE")
                favoriteColor = "sailboat";
            else if (favoriteColor.ToUpper() == "YELLOW")
                favoriteColor = "pickup truck";
            else if (favoriteColor.ToUpper() == "GREEN")
                favoriteColor = "rusted bicycle";
            else if (favoriteColor.ToUpper() == "BLUE")
                favoriteColor = "Buick";
            else if (favoriteColor.ToUpper() == "INDIGO")
                favoriteColor = "VW bus";
            else if (favoriteColor.ToUpper() == "VIOLET")
            favoriteColor = "crap station wagon";

            //This determines the user's bank account

            //This find's the letter at a particular position in the user's birth month.
            char c0 = birthMonth[0];
            char c1 = birthMonth[1];
            char c2 = birthMonth[2];

            //This searches the user's first name and determines whether the (0,1st,2nd,3rd...etc) 
            //letter in their birth month is found in their first or last name. 
            int firstNameResult0 = firstName.IndexOf(c0);
            int lastNameResult0 = lastName.IndexOf(c0);
            int firstNameResult1 = firstName.IndexOf(c1);
            int lastNameResult1 = lastName.IndexOf(c1);
            int firstNameResult2 = firstName.IndexOf(c2);
            int lastNameResult2 = lastName.IndexOf(c2);


            //This adds up the result
            int finalResult0 = (firstNameResult0 + lastNameResult0);
            int finalResult1 = (firstNameResult1 + lastNameResult1);
            int finalResult2 = (firstNameResult2 + lastNameResult2);

            int money;

            if (finalResult0 >= -1)
            {
                money = 40000;
            }

            else if (finalResult1 >= -1)
            {
                money = 100000;
            }

            else if (finalResult2 >= -1)
            {
                money = 1000000;
            }

            else
            {
                money = 0;
            }


            //This prints out the user's fortune:

            Console.WriteLine(""+ firstName +" "+ lastName +" will retire in "+ yearsToRetirement +" years with "+ money +" dollars in the bank, a vacation home in "+ numberOfSiblings +" and a "+ favoriteColor +"");



                //This asks the user if they would like to try again
                Console.Write("Would you like to try again y/n?: ");
                string again = Console.ReadLine();

                if (again.ToLower() != "y")
                {
                    Console.WriteLine("GoodBye");
                    break;
                }
            }


            Console.ReadKey();

        }
    }
}
