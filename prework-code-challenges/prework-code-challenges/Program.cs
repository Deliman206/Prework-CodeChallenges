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
            int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, chosenNum;
            int[] numArray = new int[5] { num1, num2, num3, num4, num5 };
            int multiplier = 0;
            string[] questions = new string[5] { "Your First Number...", "Your Second Number...", "Your Third Number...", "Your Fourth Number...", "Your Fifth Number..." };
            Console.WriteLine("Hello! This is interactive game, so what's your name?");
            userName = Console.ReadLine();
            Console.WriteLine("Well {0} I'm pleased to meet you,\nI am the computer. Salutations!", userName);
            Console.WriteLine("Let's get started shall we. Please enter 5 numbers between 1-10.\nI will prompt you for each one individually.");
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                Int32.TryParse(Console.ReadLine(), out int num);
                if (num > 10 || num < 1)
                {
                    Console.WriteLine("That Number is not between 1-10, please try again.");
                    i--;
                }
                numArray[i] = num;
            }

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