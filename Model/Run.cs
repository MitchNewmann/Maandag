using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Gates.Model
{
    class Run
    {
        static int numLife = 1;
        static int lifePoints = 5;
        static int room = 1;
        static string finalMessage = "";

        public static void runGame()
        {
            Console.Clear();

            while (room!=8 || lifePoints > 0)
            {
                switch (room)
                {
                    case 1:
                        Console.WriteLine("You are on a field\nPlease choose which way to go!\n1.Mountain\n2.Forest");
                        
                        if (Model.ChoiceGeneric.makeChoice(Console.ReadLine()) == 1)
                        {
                            room = 3;
                        }
                        else if (Model.ChoiceGeneric.makeChoice(Console.ReadLine()) == 2)
                        {
                            room = 2;
                        }
                        else
                        {
                            Console.WriteLine("Your choice is invalide.\nMake a valide choice!");
                            Console.WriteLine();
                        };

                        break;
                    case 2:
                        Console.WriteLine("You are in the forest. Conditions are unfavorable.\n" +
                                          "You've lost 2 life points.\nPlease choose which way to go!\n1.Desert\n2.Town");

                        while (room != 6 || room != 5)
                        {
                            if (Model.ChoiceGeneric.makeChoice(Console.ReadLine()) == 1)
                            {
                                room = 6;
                            }
                            else if (Model.ChoiceGeneric.makeChoice(Console.ReadLine()) == 2)
                            {
                                room = 5;
                            }
                            else if(Console.ReadLine().ToLower() == "quit")
                            {

                            }
                            else
                            {
                                Console.WriteLine("Your choice is invalide.\nMake a valide choice!");
                            }
                        }

                        ;

                        lifePoints = lifePoints - 2;

                        if (numLife < 3)
                        {
                            Console.WriteLine("You've found a magical plant that's given to You one extra life.");
                            numLife = numLife + 1;
                        }
                        break;
                }

                if (lifePoints < 1)
                {
                    finalMessage = "You've died.\nWanna try again?\nIf yes, press '1'!";
                    Console.WriteLine(finalMessage);
                    string yesOrNo = Console.ReadLine();

                    if (ChoiceGeneric.makeChoice(yesOrNo) == 1)
                    {
                        runGame();
                    }

                }

                if (room == 8)
                {
                    Console.WriteLine(finalMessage = "You've successfully completed the first round");
                }

            }
            
        }
    }
}
