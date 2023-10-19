using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    internal class ConsoleIO
    {
        //Main menu
        public void PrintMenu()
        {
            //Loop
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("++++++++++++++++++++++++++++");
                Console.WriteLine("++++++++++++++++++++++++++++");
                Console.WriteLine("++ ExxoPlanet Simulator   ++");
                Console.WriteLine("++++++++++++++++++++++++++++");
                Console.WriteLine("++ [1] Add life form(s    ++");
                Console.WriteLine("++ [2] Print life forms   ++");
                Console.WriteLine("++ [3] Set biosphere      ++");
                Console.WriteLine("++ [4] Set biosphere      ++");
                Console.WriteLine("++++++++++++++++++++++++++++");
                Console.WriteLine("++ [5] Avsluta            ++");
                Console.WriteLine("++++++++++++++++++++++++++++");
                Console.WriteLine("++++++++++++++++++++++++++++");

                Console.Write("\nDitt val:");
                Console.ReadKey();
            }
        }

        public int GetMenuChoice()
        {
            do
            {
                PrintMenu();

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if(choice >= 1 && choice <= 4)
                    return choice;
                }
                else
                {
                    Console.WriteLine("Knappa in ett giltigt val");
                }
            } while (true);
        }



        //Method for getting correct user input
        public int GetUserInput()
        {
            while (true)
            {
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Knappa in ett giltigt val");
                }
            }
        }
    }
}
