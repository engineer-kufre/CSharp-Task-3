using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Level Selector
            Console.WriteLine("Choose Your Level!");
            Console.WriteLine(" * Enter 1 for Easy");
            Console.WriteLine(" * Enter 2 for Medium");
            Console.WriteLine(" * Enter 3 for Hard");
            Console.Write("Level: ");
            string level = Console.ReadLine();
            int numberOfGuesses = 0;

            // Easy Level
            if (level == "1") {
                numberOfGuesses = 6;
                string secretNumber = "7";

                while (numberOfGuesses > 0) {
                    numberOfGuesses -= 1;
                    Console.Write("Guess a number between 1 and 10: ");
                    string guess = Console.ReadLine();
                    if (guess == secretNumber) {
                        Console.WriteLine("You got it right!");
                        break;
                    } else {
                        Console.WriteLine("That was wrong");
                        if (numberOfGuesses == 1) {
                            Console.WriteLine("You have " + numberOfGuesses + " guess left!");
                        } else {
                            Console.WriteLine("You have " + numberOfGuesses + " guesses left!");
                        }
                    }
                }
            }

            // Medium Level
            else if (level == "2") {
                numberOfGuesses = 4;
                string secretNumber = "17";
                
                while (numberOfGuesses > 0) {
                    numberOfGuesses -= 1;
                    Console.Write("Guess a number between 1 and 20: ");
                    string guess = Console.ReadLine();
                    if (guess == secretNumber) {
                        Console.WriteLine("You got it right!");
                        break;
                    } else {
                        Console.WriteLine("That was wrong");
                        if (numberOfGuesses == 1) {
                            Console.WriteLine("You have " + numberOfGuesses + " guess left!");
                        } else {
                            Console.WriteLine("You have " + numberOfGuesses + " guesses left!");
                        }
                    }
                }
            }
            
            // Hard Level
            else if (level == "3") {
                numberOfGuesses = 3;
                string secretNumber = "37";
                
                while (numberOfGuesses > 0) {
                    numberOfGuesses -= 1;
                    Console.Write("Guess a number between 1 and 50: ");
                    string guess = Console.ReadLine();
                    if (guess == secretNumber) {
                        Console.WriteLine("You got it right!");
                        break;
                    } else {
                        Console.WriteLine("That was wrong");
                        if (numberOfGuesses == 1) {
                            Console.WriteLine("You have " + numberOfGuesses + " guess left!");
                        } else {
                            Console.WriteLine("You have " + numberOfGuesses + " guesses left!");
                        }
                    }
                }
            }

            // Game Over
            if (numberOfGuesses == 0) {
                Console.WriteLine("Game Over!");
            }
        }
    }
}
