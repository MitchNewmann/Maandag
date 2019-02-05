using System;
using Gates.Model;

namespace Gates.Rooms
{
    class Desert
    {
        public static void LoadDesert()
        {
            Run._room = 6;

            Console.Clear();

            switch (Run.input)
            {
                case (int)RoomList.Rooms.town:
                    Town.LoadTown();
                    break;
                case (int)RoomList.Rooms.beach:
                    Beach.LoadBeach();
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
