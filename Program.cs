using System;

namespace UserMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            //A switch that holds the menu open
            do
            {
                MenuOptions();//Displays the Meny options

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Welcome to the Cinema!");
                        int party = int.Parse(UserAnswer("How many are in your party?"));//
                        
                        






                        //Add a case for Menu option 1
                        //Check age and calculate ticket prices
                        //Display group size and cost of tickets
                        break;

                    case "2":
                        //Add a case for Menu option 2
                        //Ask user for string input
                        //Display string ten times on same line
                        break;

                    case "3":
                        //Add a case for Menu option 3
                        //Ask user for a sentence
                        //Split sentence at the spaces
                        //Display third word of sentence
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;

                }
            } while (true);

            

        }

        private static string UserAnswer(string prompt)
        {
            string input;
            bool success = false;
            do
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input invalid. Please try again.");
                }
                else
                {
                    success = true;
                }
            } while (!success);
             return input;
        }

        private static void MenuOptions()
        {
            Console.WriteLine("Welcome to the Main Menu! Please make a selection: ");
            Console.WriteLine("1. Purchase tickets");
            Console.WriteLine("2. Word Multiplier");
            Console.WriteLine("3. Word Extracter");
            Console.WriteLine("4. Exit");
        }
    }
}
