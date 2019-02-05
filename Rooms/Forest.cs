using System;
using System.Collections.Generic;
using System.Text;
using Gates.Model;

namespace Gates.Rooms
{
    class Forest
    {
        

        public static void loadForest()
        {
            Console.Clear();

             

            Console.WriteLine("You are in the forest. Conditions are unfavorable.\n" +
                              "You've lost {0} life points.\nPlease choose which way to go!\n1.Desert\n2.Town", Run.pointsLost);

        }
    }
}
