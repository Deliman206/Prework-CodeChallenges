using System;

//Given an array select a number that exists, and output the computated "score". 
//The method you create should take in both an array of integers and the integer the user selected.

//Create a Console application that requests 5 numbers between 1-10. Output the array to the console and
//Ask the user to select a number.After the selection, output the "score" of the number chosen.


namespace prework_code_challenges
{
    class ArrayMultiplier
    {
        static void Main(string[] args)
        {
            string userName;
            int chosenNum;
            int multiplier = 0;
            Console.WriteLine("Hello! This is interactive game, so what's your name?");
            userName = Console.ReadLine();
            Console.WriteLine("Well {0} I'm pleased to meet you,\nI am the computer. Salutations!", userName);
            Console.WriteLine("Let's get started shall we. Please enter 5 numbers between 1-10.\nI will prompt you for each one individually.");
            Console.WriteLine("Your First Number...");
            Int32.TryParse(Console.ReadLine(), out int num1);
            if (num1 > 10 || num1 < 1)
            {
                Console.WriteLine("oops you fucked up");
            }
            Console.WriteLine("Your Second Number...");
            Int32.TryParse(Console.ReadLine(), out int num2);
            Console.WriteLine("Your Third Number...");
            Int32.TryParse(Console.ReadLine(), out int num3);
            Console.WriteLine("Your Fourth Number...");
            Int32.TryParse(Console.ReadLine(), out int num4);
            Console.WriteLine("Your Fifth Number...");
            Int32.TryParse(Console.ReadLine(), out int num5);
            int[] numArray = new int[5] { num1, num2, num3, num4, num5 };
            Console.WriteLine("Fantastic! Now choose any one of those Numbers and I will tell you your Score.");
            Int32.TryParse(Console.ReadLine(), out chosenNum);

            foreach (int num in numArray)
            {
                if (num == chosenNum)
                {
                    multiplier += 1;
                }
            }
            int score = chosenNum * multiplier;
            Console.WriteLine("Your Score is {0}! Congratz and Thanks for playing!", score);
        }
    }
}