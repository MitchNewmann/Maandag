using System;
using System.Collections.Generic;
using System.Text;
using Gates.Model;

namespace Gates.Rooms
{
    class Field
    {
        public static void loadField()
        {
            Console.Clear();

            if (Run.input == (int)RoomList.Rooms.mountain)
            {
                Mountain.loadMountain();
            }
            else if (Run.input == (int)RoomList.Rooms.forest)
            {
                Forest.loadForest();
            }
            else
            {
                Model.InvalidInput.invalidInput();
            }
            

            Console.WriteLine("You are on a field\nPlease choose which way to go!\n1.Mountain\n2.Forest");

        }
    }
}
