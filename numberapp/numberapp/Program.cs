using System;


// Name Space
namespace numberapp
{ // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // display app info
            GetAppInfo();
            // greet user
            GreetUser();
            // Set correct number and guess number
            while (true)
            {

            
            int guessNum = 0;
            Random random = new Random();
            int correctNum = random.Next(1, 10);
            Console.WriteLine("Guess a number between 1 - 10");
            // While guess is not correct
            while (guessNum != correctNum)
            {
                string guess = Console.ReadLine();

                if (!int.TryParse(guess, out guessNum))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry but you need to guess a number");
                    Console.ResetColor();
                    continue;
                }
                // convert to int and put into guess
                guessNum = Int32.Parse(guess);

                    if (guessNum != correctNum)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You guess wrong");
                        if (guessNum < correctNum)
                        {
                            Console.WriteLine("you guessed to low");
                        }
                        if (guessNum > correctNum)
                        {
                            Console.WriteLine("you guessed to high");
                        }
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Well Done, you did it! :)");
                        Console.ResetColor();
                        Console.WriteLine("Do you wish to play again? [Y or N]");
                        string answer = Console.ReadLine().ToUpper();
                        if (answer == "Y")
                        {
                            continue;
                        }
                        else if (answer == "N")
                        {
                            return;
                        }
                        else
                        {
                            return;
                        }


                    }


                }


            }
        }
        static void GetAppInfo()
        {
            string appName = "NumberGuesser";
            string version = "1.0.0";
            string author = "Alex Spencer";

            // Change Text colour
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, version, author);

            //Reset console colour
            Console.ResetColor();
        }
        static void GreetUser()
        {
            Console.WriteLine("What is your name?");

            // get input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game", inputName);
        }
    }
}

