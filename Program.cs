using System;
using System.Collections.Generic;
using System.Text;
using Gates.Model;

namespace Gates
{
	class Program
	{
		static void Main(string[] args)
		{
			Logo.printLogo();

			Player.introduction();

			Console.WriteLine("Please make a choice!\n1. New Game\n2. Quit\n");
			string whatToDo = Console.ReadLine();

			int toDo = ChoiceGeneric.makeChoice(whatToDo);

			if (toDo == 1)
			{
				Run.RunGame();
			}
		}
	}
}
