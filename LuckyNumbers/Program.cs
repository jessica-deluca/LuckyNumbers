using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loop
            // repeat certain code over and over as long as certain condition is true
            // will check the condition to see if its met, and if not, it will skip the loop

            // do-while loop
            // will always be executed at least once

            // for loop
            // good for counting
            // has three components: initial state, condition, action performed at the end

            string playAgain; // added for PART 4
            do // added for PART 4
            {
                double jackpot = 1000000d;
                Console.WriteLine("Welcome to the Lucky Numbers game! Today's jackpot is $" + jackpot + ".");

                // PART 1

                Console.WriteLine("Enter a starting number for the lowest number in the number range.");
                int lowNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a starting number for the highest number in the number range.");
                int highNumber = int.Parse(Console.ReadLine());

                int[] userNumbers = new int[6];

                for (int i = 0; i <= userNumbers.Length - 1; i++) // i needs to start at index 0 (i=0); continue until it reaches index 5; and update by adding 1 (i++)
                {
                    Console.WriteLine("Enter a number between the number range.");
                    int userInput = int.Parse(Console.ReadLine());
                    while (userInput < lowNumber || userInput > highNumber)
                    {
                        Console.WriteLine("Please enter a valid number.");
                        userInput = int.Parse(Console.ReadLine());
                    }
                    userNumbers[i] = userInput;
                }

                // PART 2

                int[] luckyNumbers = new int[6];
                Random randomNumber = new Random();

                for (int i = 0; i <= luckyNumbers.Length - 1; i++)
                {
                    luckyNumbers[i] = randomNumber.Next(lowNumber, highNumber + 1); // why do i need to enter +1 here instead of ++ to stay within the correct number range?
                    Console.WriteLine("Lucky Number: " + luckyNumbers[i]);
                }

                // PART 3

                int numbersGuessedCorrectly = 0;

                foreach (int guess in userNumbers)
                {
                    while (guess == luckyNumbers[0] || guess == luckyNumbers[1] || guess == luckyNumbers[2] || guess == luckyNumbers[3] || guess == luckyNumbers[4] || guess == luckyNumbers[5])
                    {
                        numbersGuessedCorrectly++;
                        break; // this is necessary but i don't know why
                    }
                }
                Console.WriteLine("You guessed " + numbersGuessedCorrectly + " numbers correctly!");

                // percentage of numbers guessed correctly = percentage of jackpot user wins

                double percentageGuessedCorrectly = numbersGuessedCorrectly / 6d;

                double userWinnings = jackpot * percentageGuessedCorrectly;

                // if i just use string userWinningsDollar = userWinnings.ToString("C2") then 0 is converted to "Infinity"
                // if else created to account for $0.00 if 0 numbers are guessed correctly and therefore user gets $0.00 winnings

                string userWinningsDollar;

                if (userWinnings == 0)
                {
                    userWinningsDollar = "$0.00";
                }
                else
                {
                    userWinningsDollar = userWinnings.ToString("C2");
                }

                Console.WriteLine("You won " + userWinningsDollar + "!");

                // PART 4

                Console.WriteLine("Would you like to play again? Please enter Yes or No.");
                playAgain = Console.ReadLine().ToUpper();
                if (playAgain == "NO")
                {
                    Console.WriteLine("Thanks for playing!");
                }
            }
            while (playAgain == "YES"); // repeats game if user enters yes

        }
        }
}
