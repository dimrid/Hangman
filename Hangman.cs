using System;

namespace Hangman
{
    public class Hangman
    {
        public void PrintHangman(int wrongTries)
        {
            if(wrongTries > 3)
            {
                Console.WriteLine("__________ ");
            }
            if(wrongTries > 4)
            {
                Console.WriteLine(" |/      | ");
            }
            else if(wrongTries > 2)
            {
                Console.WriteLine(" |/      ");
            }

            if(wrongTries > 8)
            {
                Console.WriteLine(" |      (_) ");
                Console.WriteLine(" |      \\|/ ");
                Console.WriteLine(" |       |  ");
                Console.WriteLine(" |      / \\ ");
            }
            else if (wrongTries > 7)
            {
                Console.WriteLine(" |      (_) ");
                Console.WriteLine(" |      \\|/ ");
                Console.WriteLine(" |       |  ");
                Console.WriteLine(" | ");
            }
            else if (wrongTries > 6)
            {
                Console.WriteLine(" |      (_) ");
                Console.WriteLine(" |      \\|/ ");
                Console.WriteLine(" | ");
                Console.WriteLine(" | ");
            }
            else if (wrongTries > 5)
            {
                Console.WriteLine(" |      (_) ");
                Console.WriteLine(" | ");
                Console.WriteLine(" | ");
                Console.WriteLine(" | ");
            }
            else if (wrongTries > 1)
            {
                Console.WriteLine(" | ");
                Console.WriteLine(" | ");
                Console.WriteLine(" | ");
                Console.WriteLine(" | ");
            }
            if (wrongTries > 0)
            {
                Console.WriteLine("_|___");
            }
        }
    }
}

