using System;

namespace Exponents
{
    class MainClass
    {
   
        public static void Main(string[] args)
        {
            //1291 (if, else) nesting the main function in the not to high, not too low
            int low = 0;
            int high = 1291;
            bool goOn = true;
            while (goOn == true)
            {
               string userNumber = GetUserInput("integer (no negatives and no greater than 1290)");

                try
                {
                    int userNum = int.Parse(userNumber);
                    if (userNum < low)
                    {
                        throw new Exception("Your number is too low, try again");

                    }
                    else if (userNum > high)
                    {
                        throw new Exception("Your number is too high, try again");
                    }
                   
                    GetExponents(userNum);
                    goOn = GetContinue();
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hey that was not a valid int, please try again ");
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }


            }
        }

        //functions for getting user data
        public static string GetUserInput(string desiredInput)
        {
            Console.WriteLine($"Please input a {desiredInput}");
            string input = Console.ReadLine();
            return input;
        }

        //Method for display the numbers
        public static void GetExponents(int userNum)
        {
            for (int i = 1; i < userNum; i++)
            {
                Console.WriteLine($"{i} \t{ i * i} \t{ i * i * i}");
            }
        }

        //Method for con
        public static bool GetContinue()
        {
            Console.WriteLine("Would you like to continue? y/n");
            string answer = Console.ReadLine();

            //There are 3 cases we care about 
            //1) y - we want to continue 
            //2) n - we want to stop 
            //3) anything else - we want to try again

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that, please try again");
                //Calling a method inside itself is called recursion
                //Think of this as just trying again 
                return GetContinue();
            }
        }


    }

}