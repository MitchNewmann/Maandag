using System;
using System.Collections.Generic;
using System.Text;
using Gates.Model;

namespace Gates.Rooms
{
    class Mountain
    {
        public static void LoadMountain()
        {
            Run._room = 3;

            Console.Clear();

            switch (Run.input)
            {
                case (int)RoomList.Rooms.field:
                    Field.LoadField();
                    break;
                case (int)RoomList.Rooms.beach:
                    Beach.LoadBeach();
                    break;
                default:
                    InvalidInput.invalidInput();
                    break;
            }
        }
    }
}
