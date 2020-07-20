using System;
using System.Reflection.Metadata.Ecma335;

namespace Lab_4._1_Dice_Rolling
{
    class Program
    {
        static void Main()
        {
            CrapsGame();
        }
        static int DiceRoll(int d1)
        {
            //Method that creates a random number between 1 and the number entered. Returns a value between 1 and d1
            Random random = new Random();
            int result = random.Next(1, d1 + 1);
            return result;
        }

        static void Restart()
        {
            //Method called to restart. If 'Y', count will increase inside Crapsgame Method
            Console.WriteLine("Quit?. Y/N?");
            string y = Console.ReadLine().ToLower();
            if (y == "y")
            {
                Environment.Exit(1);
            }
        }

        static void RollCall(int printout)
        {
            if (printout == 1)
            {
                Console.WriteLine(" _____");
                Console.WriteLine("|     |");
                Console.WriteLine("|  o  |");
                Console.WriteLine("|_____|");
            }
            if (printout == 2)
            {
                Console.WriteLine(" _____");
                Console.WriteLine("|    o|");
                Console.WriteLine("|     |");
                Console.WriteLine("|o____|");
            }
            if (printout == 3)
            {
                Console.WriteLine(" _____");
                Console.WriteLine("|    o|");
                Console.WriteLine("|  o  |");
                Console.WriteLine("|o____|");
            }
            if (printout == 4)
            {
                Console.WriteLine(" _____");
                Console.WriteLine("|o   o|");
                Console.WriteLine("|     |");
                Console.WriteLine("|o___o|");
            }
            if (printout == 5)
            {
                Console.WriteLine(" _____");
                Console.WriteLine("|o   o|");
                Console.WriteLine("|  o  |");
                Console.WriteLine("|o___o|");
            }
            if (printout == 6)
            {
                Console.WriteLine(" _____");
                Console.WriteLine("|o   o|");
                Console.WriteLine("|o   o|");
                Console.WriteLine("|o___o|");
            }
        }

        static void CrapsGame()
        {
            //Declare variables, all running through loop to continue/exit when prompted.
            int count = 0;
            bool runwhile = true;
            while (runwhile == true)
            {
                //Take input, convert to int and reference it twice when sending to Random method.
                count++;
                Console.WriteLine("Welcome to the Grand Circus Casino!");
                Console.WriteLine("How many sides should each die(2) have?");
                string entry = Console.ReadLine();
                int game = int.Parse(entry);

                //Results of the game, assigning returned random values to ints so they can be prepared for winning print outs.
                Console.WriteLine($"Here are the results of Roll #{count}!");
                if (game == 6)
                {
                    int roll1 = DiceRoll(game);
                    int roll2 = DiceRoll(game);
                    int total = roll1 + roll2;
                    Console.WriteLine($"Your first roll:{roll1}  Your second roll:{roll2}  Your total is {total} ");
                    RollCall(roll1);
                    RollCall(roll2);
                    //Here are the possible results of the craps game
                    if (total == 2 || total == 3 || total == 12)
                    {
                        Console.WriteLine("Craps");
                    }
                    if (roll1 == 1 || roll1 == 2 || roll2 == 1 || roll2 == 2)
                    {
                        Console.WriteLine("Ace Deuce");
                    }
                    if (total == 2)
                    {
                        Console.WriteLine("Snake Eyes");
                    }
                    if (total == 12)
                    {
                        Console.WriteLine("Box Cars");
                    }
                    if (total == 7 || total == 11)
                    {
                        Console.WriteLine("You win!");
                    }
                    Restart();
                }

                //If the sides of the dice are not = to 6, just print out this basic statement.
                else if (game != 6)
                {
                    int roll1 = DiceRoll(game);
                    int roll2 = DiceRoll(game);
                    int total = roll1 + roll2;
                    Console.WriteLine($"Your first roll:{roll1}  Your second roll:{roll2}  Your total is {total} ");
                    Restart();
                }
            }
        }
    }
}
