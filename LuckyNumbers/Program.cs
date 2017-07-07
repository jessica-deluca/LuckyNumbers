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
                luckyNumbers[i] = randomNumber.Next(lowNumber, highNumber++);
                Console.WriteLine("Lucky Number: " + luckyNumbers[i]);
            }

            // PART 3

            // The program should count the number of correctly guessed numbers and output to the console to notify the user.
            // Example: You guessed 3 numbers correctly!

            //int numbersGuessedCorrectly = 0;

            //// this runs an infinite number of times
            //foreach (int guess in userNumbers)
            //{
            //    while (guess == luckyNumbers[0] || guess == luckyNumbers[1] || guess == luckyNumbers[2] || guess == luckyNumbers[3] || guess == luckyNumbers[4] || guess == luckyNumbers[5])
            //    {
            //        numbersGuessedCorrectly++;
            //        Console.WriteLine("You guessed " + numbersGuessedCorrectly + "numbers correctly!");
            //    }
            //}

            // did not work:
            //foreach (int guess in userNumbers)
            //{
            //    do
            //    {
            //        numbersGuessedCorrectly++;
            //        Console.WriteLine("You guessed " + numbersGuessedCorrectly + "numbers correctly!");
            //    }
            //    while (guess == luckyNumbers[0] || guess == luckyNumbers[1] || guess == luckyNumbers[2] || guess == luckyNumbers[3] || guess == luckyNumbers[4] || guess == luckyNumbers[5]);
            //}

            // did not work:
            //foreach (int guess in userNumbers)
            //{
            //    numbersGuessedCorrectly++;
            //    Console.WriteLine("You guessed " + numbersGuessedCorrectly + " numbers correctly!");
            //    while (guess == luckyNumbers[0] || guess == luckyNumbers[1] || guess == luckyNumbers[2] || guess == luckyNumbers[3] || guess == luckyNumbers[4] || guess == luckyNumbers[5]);
            //}

            // The program should calculate the user's winnings based on the number of numbers guessed correctly.
            // double userWinnings = jackpot % numbersGuessedCorrectly;

            // The user's winnings should be output to the console.
            // Example: You won $256, 877.23!
            // Console.WriteLine("You won $" + userWinnings + "!");

            // PART 4

            //entire game is do-while loop
            //string playAgain;
            //do
            //{
            //    enter the code to the game here
            //    Console.WriteLine("Would you like to play again? Please enter "Yes" or "No."");
            //    playAgain = Console.ReadLine().ToUpper();
            //    if (playAgain == "NO")
            //    {
            //      Console.WriteLine("Thanks for playing!");
            //    }
            //}
            //while (playAgain == "YES");

        }
    }
}
