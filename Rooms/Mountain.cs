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

            Console.WriteLine("You are in the mountains, training hard. For this you get 2 life points." +
                "\nPress 1 to go to the field.\nPress 4 to go to the beach.");

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
