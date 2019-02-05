using System;
using System.Collections.Generic;
using System.Text;
using Gates.Model;

namespace Gates.Rooms
{
    internal class Field
    {
        public static void LoadField()
        {
            Console.Clear();
            Console.WriteLine("You are on a field\nPlease choose which way to go!\n1.Mountain\n2.Forest");

            switch (Run.input)
            {
                case (int)RoomList.Rooms.mountain:
                    Mountain.LoadMountain();
                    break;
                case (int)RoomList.Rooms.forest:
                    Forest.LoadForest();
                    break;
                default:
                    InvalidInput.invalidInput();
                    break;
            }

            Run._lifePoints = Run._lifePoints - 2;

            if (Run._numLife < 3)
            {
                Console.WriteLine("You've found a magical plant that's given to You one extra life.");
                Run._numLife = Run._numLife + 1;
            }


        }
    }
}
