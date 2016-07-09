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
            
            //Read the user's last name from the user
            Console.WriteLine("What is your last name?: ");
            String lasttName = Console.ReadLine();
            
            //Read the user's age from the user
            Console.WriteLine("What is your age?: ");
            string ageAsAString = Console.ReadLine();
            int age = Convert.ToInt32(ageAsAString);
            
            //Read the user's birth month from the user
            Console.WriteLine("What is your birth month?: ");
            String birthMonth = Console.ReadLine();

            //string[] months = new string[12];
            //months[0] = "January";
            //months[1] = "February";
            //months[2] = "March";
            //months[3] = "April";
            //months[4] = "May";
            //months[5] = "June";
            //months[6] = "July";
            //months[7] = "August";
            //months[8] = "September";
            //months[9] = "October";
            //months[10] = "November";
            //months[11] = "December";











            //Read the user's favorite color from the user
            Console.WriteLine("What is your favorite ROYGBIV color?  If you don't know what a ROYGBIV color is, enter \"Help\": ");
            string favoriteColor = Console.ReadLine();
         
            while (favoriteColor == "Help")
            
            {
                Console.WriteLine("A ROYGBIV color includes Red, Orange, Yellow, Green, Blue, Indigo and Violet.  Which do you choose?: ");
                favoriteColor = Console.ReadLine();
            }
            
                                                                      
            //Read the number of siblings from the user
            Console.WriteLine("How many siblings do you have?: ");
            string numberOfSiblings = Console.ReadLine();
            
            //This determines the user's time to retirement            
                if (age % 2 == 1)
                age = 3;
                else if (age % 2 == 0)
                age = 5;

            //This determines where the user will live
                if (numberOfSiblings == "0")
                numberOfSiblings = "Boston";
                else if (numberOfSiblings == "1")
                numberOfSiblings = "Cleveland";
                if (numberOfSiblings == "2")
                numberOfSiblings = "Miami";
                else if (numberOfSiblings == "3")
                numberOfSiblings = "Orlando";
                else
                numberOfSiblings = "New York";

            //This determines the user's mode of transport
            if (favoriteColor == "Red")
                favoriteColor = "car";
            else if (favoriteColor == "Orange")
                favoriteColor = "horse";
            else if (favoriteColor == "Yellow")
                favoriteColor = "Pig";
            else if (favoriteColor == "Green")
                favoriteColor = "fish";
            else if (favoriteColor == "Blue")
                favoriteColor = "walrus";
            else if (favoriteColor == "Indigo")
                favoriteColor = "dog";
            else if (favoriteColor == "Violet")
            favoriteColor = "cat";

            //This determines the user's money
            if (birthMonth == "1")
                birthMonth = "January";
            if (birthMonth == "2")
                birthMonth = "February";
            if (birthMonth == "3")
                birthMonth = "March";
            if (birthMonth == "4")
                birthMonth = "April";
            if (birthMonth == "5")
                birthMonth = "May";
            if (birthMonth == "6")
                birthMonth = "June";
            if (birthMonth == "7")
                birthMonth = "July";
            if (birthMonth == "8")
                birthMonth = "August";
            if (birthMonth == "9")
                birthMonth = "September";
            if (birthMonth == "10")
                birthMonth = "October";
            if (birthMonth == "11")
                birthMonth = "November";
            if (birthMonth == "12")
                birthMonth = "December";



            Console.WriteLine(""+ firstName +" will retire in " + age +" years and live in "+ numberOfSiblings +". He will ride a "+ favoriteColor +"");
            
            Console.ReadKey();

        }
    }
}
