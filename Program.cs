using System;

namespace Gates
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.Logo.printLogo();

            Model.Player.introduction();

            Console.WriteLine("Please make a choice!\n1. New Game\n2. Quit\n");
            string whatToDo = Console.ReadLine();

            int toDo = Model.ChoiceGeneric.makeChoice(whatToDo);

            if (toDo==1)
            {
                Model.Run.runGame();
            }
        }
    }
}
