using System;
using Gates.Rooms;

namespace Gates.Model
{
    class Run
    {
        public static int _numLife = 1;
        public static int _lifePoints = 5;
        public static int _room = 1;
        public static Random pointsLost = new Random(1-5);
        static string _finalMessage = "";
        public static int input;

        public static void RunGame()
        {
            Console.Clear();

            Field.LoadField();

            input = ChoiceGeneric.makeChoice(Console.ReadLine());

            while (_room!=8 || _lifePoints > 0)
            {
                if (Console.ReadLine().ToLower() == "quit")
                {
                    break;
                }

                switch (_room)
                {
                    //#1 Field
                    case (int)RoomList.Rooms.field:

                        Field.LoadField();
                        continue;
                    //#2 Forest
                    case (int)RoomList.Rooms.forest:
                    {
                        Forest.LoadForest();
                        continue;
                    }
                    //#3 Mountain
                    case (int)RoomList.Rooms.mountain:
                    {
                        Mountain.LoadMountain();
                        continue;
                    }
                    //#4 Beach
                    case (int)RoomList.Rooms.beach:
                    {
                        Beach.LoadBeach();
                        continue;
                    }
                    //#5 Town
                    case (int)RoomList.Rooms.town:
                    {
                        Town.LoadTown();
                        continue;
                    }
                    //#6 Desert
                    case (int)RoomList.Rooms.desert:
                    {
                        Desert.LoadDesert();
                        continue;
                    }
                    //#7 Cave
                    case (int)RoomList.Rooms.cave:
                        break;
                }


                if (_lifePoints < 1)
                {
                    _finalMessage = "You've died.\nWanna try again?\nIf yes, press '1'!";
                    Console.WriteLine(_finalMessage);
                    var yesOrNo = Console.ReadLine();

                    if (ChoiceGeneric.makeChoice(yesOrNo) == 1)
                    {
                        RunGame();
                    }

                }

                if (_room == 8)
                {
                    Console.WriteLine(_finalMessage = "You've successfully completed the first round");
                }

            }
            
        }
    }
}
