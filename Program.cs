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
            int secretNumber = 0;
            int guess = 0;
            Random rnd = new Random();

            // Easy Level
            if (level == "1") {
                numberOfGuesses = 6;
                secretNumber = rnd.Next(1, 11);

                while (numberOfGuesses > 0) {
                    numberOfGuesses -= 1;

                    try {
                        Console.Write("Guess a number between 1 and 10: ");
                        guess = int.Parse(Console.ReadLine());
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

                    catch (FormatException) {
                        Console.WriteLine("Please, enter only numbers!");
                        numberOfGuesses += 1;
                    }
                }
            }

            // Medium Level
            else if (level == "2") {
                numberOfGuesses = 4;
                secretNumber = rnd.Next(1, 21);
                
                while (numberOfGuesses > 0) {
                    numberOfGuesses -= 1;

                    try {
                        Console.Write("Guess a number between 1 and 20: ");
                        guess = int.Parse(Console.ReadLine());
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

                    catch (FormatException) {
                        Console.WriteLine("Please, enter only numbers!");
                        numberOfGuesses += 1;
                    }
                }
            }
            
            // Hard Level
            else if (level == "3") {
                numberOfGuesses = 3;
                secretNumber = rnd.Next(1, 51);
                
                while (numberOfGuesses > 0) {
                    numberOfGuesses -= 1;

                    try {
                        Console.Write("Guess a number between 1 and 50: ");
                        guess = int.Parse(Console.ReadLine());
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

                    catch (FormatException) {
                        Console.WriteLine("Please, enter only numbers!");
                        numberOfGuesses += 1;
                    }
                }
            }

            // Game Over
            if (numberOfGuesses == 0 && guess != secretNumber) {
                Console.WriteLine("Game Over!");
            }
        }
    }
}
