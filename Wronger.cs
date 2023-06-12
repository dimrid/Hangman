using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Wronger
    {
        void PrintHangman(int tries)
        {
            if (tries > 3)
            {
                Console.WriteLine("__________ ");
            }
            if (tries > 4)
            {
                Console.WriteLine(" |/      | ");
            }
            else if (tries > 2)
            {
                Console.WriteLine(" |/      ");
            }

            if (tries > 8)
            {
                Console.WriteLine(" |      (_) ");
                Console.WriteLine(" |      \\|/ ");
                Console.WriteLine(" |       |  ");
                Console.WriteLine(" |      / \\ ");
            }
            else if (tries > 7)
            {
                Console.WriteLine(" |      (_) ");
                Console.WriteLine(" |      \\|/ ");
                Console.WriteLine(" |       |  ");
                Console.WriteLine(" | ");
            }
            else if (tries > 6)
            {
                Console.WriteLine(" |      (_) ");
                Console.WriteLine(" |      \\|/ ");
                Console.WriteLine(" | ");
                Console.WriteLine(" | ");
            }
            else if (tries > 5)
            {
                Console.WriteLine(" |      (_) ");
                Console.WriteLine(" | ");
                Console.WriteLine(" | ");
                Console.WriteLine(" | ");
            }
            else if (tries > 1)
            {
                Console.WriteLine(" | ");
                Console.WriteLine(" | ");
                Console.WriteLine(" | ");
                Console.WriteLine(" | ");
            }
            if (tries > 0)
            {
                Console.WriteLine("_|___");
            }
        }
    }
}
