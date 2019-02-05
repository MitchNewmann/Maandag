using System;
using System.Collections.Generic;
using System.Text;
using Gates.Model;

namespace Gates.Rooms
{
    class Cave
    {
        public static void loadCave()
        {

            Run._room = 7;

            Console.Clear();

            switch (Run.input)
            {
                case (int)RoomList.Rooms.beach:
                    Beach.LoadBeach();
                    break;
                case (int)RoomList.Rooms.desert:
                    Desert.LoadDesert();
                    break;
                default:
                    InvalidInput.invalidInput();
                    break;
            }

        }
    }
}
