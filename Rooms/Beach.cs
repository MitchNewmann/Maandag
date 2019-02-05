using System;
using System.Collections.Generic;
using System.Text;
using Gates.Model;

namespace Gates.Rooms
{
    class Beach
    {
        public static void LoadBeach()
        {
            Run._room = 4;

            Console.Clear();

            Console.WriteLine("You are on the beach, resting. You get 3 extra life points.\n" +
                "Press 6 to go to the desert\nPress 7 to go to the Cave");

            switch (Run.input)
            {
                case (int)RoomList.Rooms.desert:
                    Desert.LoadDesert();
                    break;
                case (int)RoomList.Rooms.cave:
                    Cave.loadCave();
                    break;
                default:
                    InvalidInput.invalidInput();
                    break;
            }


        }
    }
}
