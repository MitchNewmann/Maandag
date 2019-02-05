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
            Console.WriteLine("You are on a field\nPlease choose which way to go!" +
                "\nPress 3 to go to the mountain\n Press 2 to go to the forest");

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

        }
    }
}
