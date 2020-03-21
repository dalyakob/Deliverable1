using System;

namespace Deliverable1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string vacationType, result;
            int groupSize;

            //Checking to see if user input is valid for vacationType
            while (true) {
                Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous?");
                vacationType = Console.ReadLine().ToLower();

                if (vacationType == "musical" || vacationType == "tropical" || vacationType == "adventurous")
                    break;
                else
                    Console.WriteLine("This option is not available, please check spelling and try again!");
            }

            //loops to check if user enters a valid and positive number for groupSize 
            while (true) {
                Console.WriteLine("How many are in your group?");

                try
                {
                    groupSize = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error, value entered is not a valid number!");
                    continue;
                }
                if (groupSize > 0)
                    break;
                else
                    Console.WriteLine("Error, please enter a positive number");

            }
            //initializing result
            result = "Since you're a group of " + groupSize.ToString() + " going on a " + vacationType + " vacation, you should take a " ;

            //Checking group size and adjusting result respectively
            if (groupSize == 1 || groupSize == 2)
                result += "First Class ";
            else if (groupSize >= 3 && groupSize <= 5)
                result += "Helicopter ";
            else if (groupSize >= 6)
                result += "Charter Flight ";

            result += "to ";

            //Checking vacationType and adjust result respectively
            if (vacationType == "musical")
                result += "New Orleans";
            else if (vacationType == "tropical")
                result += "Beach Vacation in Mexico";
            else if (vacationType == "adventurous")
                result += "WhiteWater Rafting the Grand Canyon";

            result += ".";

            //prints result
            Console.WriteLine(result);
        }
    }
}
