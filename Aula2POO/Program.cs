using Aula2POO.Classes;
using System;

namespace Aula2POO
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            do
            {
                Console.WriteLine("Enter the command: ");
                string command = Console.ReadLine();
                if (command.Equals("quit"))
                {
                    running = false;
                }
                else if (command.Equals("w"))
                {
                    var map = new Map();

                    map.Array2D = new string[10, 10];

                    map.Print();
                }
                else if (command.Equals("a"))
                {
                }
                else if (command.Equals("s"))
                {
                }
                else if (command.Equals("d"))
                {
                }
                else if (command.Equals("g"))
                {
                }
            } while (running);
        }
    }
}
