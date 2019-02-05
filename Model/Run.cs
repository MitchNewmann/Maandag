using System;
using Gates.Rooms;

namespace Gates.Model
{
    class Run
    {
        static int _numLife = 1;
        static int _lifePoints = 5;
        public static int _room = 1;
        public static Random pointsLost = new Random(1-5);
        static string _finalMessage = "";
        public static int input;

        public static void RunGame(RoomList.Rooms room)
        {
            Console.Clear();

            Field.loadField();

            input = ChoiceGeneric.makeChoice(Console.ReadLine());

            while (_room!=8 || _lifePoints > 0)
            {
                if (Console.ReadLine().ToLower() == "quit")
                {
                    break;
                }

                //#1 Field
                if (_room == (int)RoomList.Rooms.field)
                {
                    

                    continue;
                }

                //#2 Forest
                if (_room == (int)RoomList.Rooms.forest)
                {
                    if (input == (int)RoomList.Rooms.field)
                    {
                        Field.loadField();
                    }
                    else if (input == (int)RoomList.Rooms.desert)
                    {
                        Desert.loadDesert();
                    }
                    else if (input == (int)RoomList.Rooms.town)
                    {
                        Town.loadTown();
                    }
                    else
                    {
                        Model.InvalidInput.invalidInput();
                    }

                    continue;
                }

                //#3 Mountain
                if (_room == (int)RoomList.Rooms.mountain)
                {
                    if (input == (int)RoomList.Rooms.field)
                    {
                        Field.loadField();
                    }
                    else if (input == (int)RoomList.Rooms.beach)
                    {
                        Beach.loadBeach();
                    }
                    else
                    {
                        Model.InvalidInput.invalidInput();
                    }

                    continue;
                }

                //#4 Beach
                if (_room == (int)RoomList.Rooms.beach)
                {
                    if (input == (int)RoomList.Rooms.desert)
                    {
                        Desert.loadDesert();
                    }
                    else if (input == (int)RoomList.Rooms.cave)
                    {
                        Cave.loadCave();
                    }
                    else
                    {
                        Model.InvalidInput.invalidInput();
                    }

                    continue;
                }

                //#5 Town
                if (_room == (int)RoomList.Rooms.town)
                {
                    if (input == (int)RoomList.Rooms.desert)
                    {
                        Desert.loadDesert();
                    }
                    else if (input == (int)RoomList.Rooms.forest)
                    {
                        Forest.loadForest();
                    }
                    else
                    {
                        Model.InvalidInput.invalidInput();
                    }

                    continue;
                }

                //#6 Desert
                if (_room == (int)RoomList.Rooms.desert)
                {
                    if (input == (int)RoomList.Rooms.town)
                    {
                        Town.loadTown();
                    }
                    else if (input == (int)RoomList.Rooms.beach)
                    {
                        Beach.loadBeach();
                    }
                    else if (input == (int)RoomList.Rooms.cave)
                    {
                        Cave.loadCave();
                    }
                    else
                    {
                        Model.InvalidInput.invalidInput();
                    }

                    continue;
                }

                //#7 Cave
                if (_room == (int)RoomList.Rooms.cave)
                {
                    
                }


                        _lifePoints = _lifePoints - 2;

                        if (_numLife < 3)
                        {
                            Console.WriteLine("You've found a magical plant that's given to You one extra life.");
                            _numLife = _numLife + 1;
                        }
                        break;

                if (_lifePoints < 1)
                {
                    _finalMessage = "You've died.\nWanna try again?\nIf yes, press '1'!";
                    Console.WriteLine(_finalMessage);
                    string yesOrNo = Console.ReadLine();

                    if (ChoiceGeneric.makeChoice(yesOrNo) == 1)
                    {
                        RunGame(room);
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
