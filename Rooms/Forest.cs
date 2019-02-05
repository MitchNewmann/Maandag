using System;
using System.Collections.Generic;
using System.Text;
using Gates.Model;

namespace Gates.Rooms
{
    class Forest
    {
        
        public static void LoadForest()
        {
            Run._room = 2;

            Console.Clear();

            switch (Run.input)
            {
                case (int)RoomList.Rooms.field:
                    Field.LoadField();
                    break;
                case (int)RoomList.Rooms.desert:
                    Desert.LoadDesert();
                    break;
                case (int)RoomList.Rooms.town:
                    Town.LoadTown();
                    break;
                default:
                    Model.InvalidInput.invalidInput();
                    break;
            }


            Console.WriteLine("You are in the forest. Conditions are unfavorable.\n" +
                              "You've lost {0} life points.\nPlease choose which way to go!\n1.Desert\n2.Town", Run.pointsLost);

			if (Run._numLife < 3)
			{
				Console.WriteLine("You've found a magical plant that's given to You one extra life.");
				Run._numLife = Run._numLife + 1;
			}

		}

    }
}
