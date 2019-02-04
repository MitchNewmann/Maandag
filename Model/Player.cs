using System;

namespace Gates.Model
{
    class Player
    {
        public static void introduction()
        {
            Console.WriteLine("Hi there! Please tell me your name! \n");

            string name = Console.ReadLine();

            Console.WriteLine(String.Format("Welcome {0}!", name));
        }
    }
}