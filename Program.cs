using System;
using System.Collections.Generic;

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
                        int members = UserInt("How many are in your party?");
                        List<int> Ages = new List<int>();
                        int totalPrice = 0;

                        for(int i = 0; i <=members; i++)
                        {
                            int age = UserInt("Please enter the age of this person in your party: ");
                            Ages.Add(age);
                            if (age > 20) ;
                            else if (age > 100 || age < 5) { }
                            if (age > 64) { }
                            else totalPrice += 80;
                        }
                        
                      
                        






                        //Add a case for Menu option 1
                        //Check age and calculate ticket prices
                        //Display group size and cost of tickets
                        break;

                    case "2":
                        RepeatInputSameLine();//repeats string on same line
                        break;

                    case "3":
                        ExtractThirdWord();                        
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

        private static void ExtractThirdWord()
        {
            bool success = false;
            string[] words;
            do
            {
                string sentence = UserAnswer("\nWelcome to the Word Extractor!\nPlease give me a sentence and I will extract the third word:");
                string separator = " ";
                words = sentence.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                if (words.Length < 3)
                {
                    Console.WriteLine("Your entry is too short. Please write at least three words.");
                }
                else
                    success = true;
            } while (!success);

            Console.WriteLine("\nLet me pull out the third word from your phrase.");
            Console.WriteLine($"Here is your third word: {words[2]}\n");
        }

        private static void RepeatInputSameLine()
        {
            Console.WriteLine("\nLet's play a game!");
            Console.WriteLine("Tell me anything and I'll repeat it ten times: ");
            string message = Console.ReadLine();
            Console.WriteLine("My turn: ");
            for (int i = 10; i > 0; i--)
            {
                Console.Write(message + " ");
            }
            Console.WriteLine("\n ");
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

        private static int UserInt(string prompt)
        {
            int number;
            bool success = false;

            do
            {
                string input = UserAnswer(prompt);
                success = int.TryParse(input, out number);
                if (!success)
                    Console.WriteLine("Invalid input. Please enter a number.");
                
            } while (!success);
            return number;
        }

            private static void MenuOptions()
        {
            Console.WriteLine("Welcome to the Main Menu! Please make a selection: ");
            Console.WriteLine("1. Purchase tickets");
            Console.WriteLine("2. Word Multiplier");
            Console.WriteLine("3. Word Extracter");
            Console.WriteLine("4. Exit");
        }

        public enum TicketPrices
        {
            Ungdom, Pension, Standard
        }
        
    }
}
