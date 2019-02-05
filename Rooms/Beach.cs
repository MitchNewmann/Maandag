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
