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
            string playAgain; // added for PART 4
            do // added for PART 4
            {
                double jackpot = 1000000d;
                Console.WriteLine("Welcome to the Lucky Numbers game! Today's jackpot is " + jackpot.ToString("C2") + ".");

                // PART 1

                Console.WriteLine("Enter a starting number for the lowest number in the number range, then select [Enter].");
                int lowNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter an ending number for the highest number in the number range, then select [Enter].");
                int highNumber = int.Parse(Console.ReadLine());

                int[] userNumbers = new int[6]; // defining array - know how many elements but do not know what they are

                for (int i = 0; i <= userNumbers.Length - 1; i++) // i needs to start at index 0 (i=0); continue until it reaches index 5 (<= userNumbers.Length - 1); and update by adding 1 (i++)
                {
                    Console.WriteLine("Guess a lucky number between the number range, then select [Enter]. (You will guess six numbers total.)");
                    int userInput = int.Parse(Console.ReadLine());
                    while (userInput < lowNumber || userInput > highNumber) // user input must be between number range or...
                    {
                        Console.WriteLine("Please enter a valid number between the number range of " + lowNumber + " and " + highNumber + ", then select [Enter].");
                        userInput = int.Parse(Console.ReadLine());
                    }
                    userNumbers[i] = userInput; // saving user inputs in userNumbers array
                }

                // PART 2

                int[] luckyNumbers = new int[6]; // defining array - know how many elements but do not know what they are
                Random randomNumber = new Random();

                for (int i = 0; i <= luckyNumbers.Length - 1; i++)
                {
                    luckyNumbers[i] = randomNumber.Next(lowNumber, highNumber + 1); // saving random numbers in luckyNumbers array
                    Console.WriteLine("Lucky Number: " + luckyNumbers[i]);
                }

                // PART 3

                int numbersGuessedCorrectly = 0; // start at 0 because initially no numbers are guessed correctly until they are counted

                foreach (int guess in userNumbers)
                {
                    while (guess == luckyNumbers[0] || guess == luckyNumbers[1] || guess == luckyNumbers[2] || guess == luckyNumbers[3] || guess == luckyNumbers[4] || guess == luckyNumbers[5])
                    {
                        numbersGuessedCorrectly++;
                        break;
                    }
                }

                if (numbersGuessedCorrectly == 1) // if 1 number guessed correctly, console reads 1 number (number is singular)
                {
                    Console.WriteLine("You guessed " + numbersGuessedCorrectly + " number correctly!");
                }
                else  // if more than 1 number guessed correctly, console reads X numbers (number is plural)
                {
                    Console.WriteLine("You guessed " + numbersGuessedCorrectly + " numbers correctly!");
                }

                // percentage of numbers guessed correctly == percentage of jackpot user wins

                double percentageGuessedCorrectly = numbersGuessedCorrectly / 6d;

                double userWinnings = jackpot * percentageGuessedCorrectly;

                string userWinningsDollar;

                // if i just use string userWinningsDollar = userWinnings.ToString("C2") then 0 is converted to "Infinity"
                // if else created to account for $0.00 if 0 numbers are guessed correctly and therefore user gets $0.00 winnings

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

                Console.WriteLine("Would you like to play again? Please enter \"Yes\" or \"No\".");
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
