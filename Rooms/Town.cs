using System;
using System.Collections.Generic;
using System.Text;
using Gates.Model;

namespace Gates.Rooms
{
    class Town
    {
        public static void LoadTown()
        {
            Run._room = 5;

            Console.Clear();

            switch (Run.input)
            {
                case (int)RoomList.Rooms.desert:
                    Desert.LoadDesert();
                    break;
                case (int)RoomList.Rooms.forest:
                    Forest.LoadForest();
                    break;
                default:
                    InvalidInput.invalidInput();
                    break;
            }
        }
    }
}
