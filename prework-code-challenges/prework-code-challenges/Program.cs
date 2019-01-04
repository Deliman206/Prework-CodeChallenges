using System;

//Given an array select a number that exists, and output the computated "score". 
//The method you create should take in both an array of integers and the integer the user selected.

//Create a Console application that requests 5 numbers between 1-10. Output the array to the console and
//Ask the user to select a number.After the selection, output the "score" of the number chosen.


namespace prework_code_challenges
{
    //class ArrayMultiplier
    //{
    //    static void Main(string[] args)
    //    {
    //        string userName;
    //        int multiplier = 0;
    //        Console.WriteLine("Hello! This is interactive game, so what's your name?");
    //        userName = Console.ReadLine();
    //        Console.WriteLine("Well {0} I'm pleased to meet you,\nI am the computer. Salutations!", userName);
    //        Console.WriteLine("Let's get started shall we. Please enter 5 numbers between 1-10.\nI will prompt you for each one individually.");
    //        Console.WriteLine("Your First Number...");
    //        Int32.TryParse(Console.ReadLine(), out int num1);
    //        if (num1 > 10 || num1 < 1)
    //        {
    //            Console.WriteLine("oops you fucked up");
    //        }
    //        Console.WriteLine("Your Second Number...");
    //        Int32.TryParse(Console.ReadLine(), out int num2);
    //        Console.WriteLine("Your Third Number...");
    //        Int32.TryParse(Console.ReadLine(), out int num3);
    //        Console.WriteLine("Your Fourth Number...");
    //        Int32.TryParse(Console.ReadLine(), out int num4);
    //        Console.WriteLine("Your Fifth Number...");
    //        Int32.TryParse(Console.ReadLine(), out int num5);
    //        int[] numArray = new int[5] { num1, num2, num3, num4, num5 };
    //        Console.WriteLine("Fantastic! Now choose any one of those Numbers and I will tell you your Score.");
    //        Int32.TryParse(Console.ReadLine(), out int chosenNum);

    //        foreach (int num in numArray)
    //        {
    //            if (num == chosenNum)
    //            {
    //                multiplier += 1;
    //            }
    //        }
    //        int score = chosenNum * multiplier;
    //        Console.WriteLine("Your Score is {0}! Congratz and Thanks for playing!", score);
    //    }
    //}
    class LeapYear
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome I am your host, Computer. \nI will let you know if a year is a Leap Year");
            void Test()
            {
                bool con1 = true, con2 = true, con3 = true;
                Console.WriteLine("Please enter a year that you wish to know about.");
                Int32.TryParse(Console.ReadLine(), out int year);
                decimal con1Math = Decimal.Divide(year, 4);
                decimal con2Math = Decimal.Divide(year, 100);
                decimal con3Math = Decimal.Divide(year, 400);

                if ((con1Math % 1) > 0)
                {
                    con1 = false;
                }
                if ((con2Math % 1) > 0)
                {
                    con2 = false;
                }
                if ((con3Math % 1) > 0)
                {
                    con3 = false;
                }
                if (con1 & con2 & con3 || con1)
                {
                    Console.WriteLine("Yes, that year is a leap year.");
                }
                else
                {
                    Console.WriteLine("No, that year is not a leap year.");
                }
                Retry();
            }
            void Retry() {
                bool retry = false;
                Console.WriteLine("Would you like to try again? Yes or No");
                string answer = Console.ReadLine();
                if (answer == "Yes")
                {
                    retry = true;
                }
                if(answer == "No")
                {
                    Console.WriteLine("Thank you, see you soon!");
                    retry = false;
                }
                if (answer != "Yes" && answer != "No")
                {
                    Console.WriteLine("That is not a valid response.");
                    Retry();
                }
                if (retry == true)
                {
                    Test();
                }
            }
            Test();
        }

    }
}