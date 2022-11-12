using System;
namespace SHVFS_P101_GD08_Oprah
{
    public class program
    {
        public static void Main()
        {

            Game[] sunnyhomeland = new Game[5];
            sunnyhomeland[0] = new Game("Cloud", 1, 1, 1);
            sunnyhomeland[1] = new Game("Johnny", 2, 2, 2);
            sunnyhomeland[2] = new Game("Bandy", 3, 3, 3);
            sunnyhomeland[3] = new Game("Naomi", 1, 1, 1);
            sunnyhomeland[4] = new Game("Oprah", 4, 4, 4);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j) continue;
                    if (sunnyhomeland[i].compare(sunnyhomeland[j]))
                    {
                        Console.WriteLine($"No.{i} and No.{j} have the same position of [{sunnyhomeland[i].pos.X},{sunnyhomeland[i].pos.X},{sunnyhomeland[i].pos.X}]");
                    }
                }
            }
            Console.ReadLine();
        }


        public struct Position
        {
            public int X;
            public int Y;
            public int Z;

            public Position(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }

        }
        public class Game
        {
            public string Name;
            public Position pos;

            public Game(string name, int x, int y, int z)
            {
                Name = name;
                pos.X = x;
                pos.Y = y;
                pos.Z = z;
            }

            public bool compare(Game game)
            {
                return game.pos.X == pos.X && game.pos.Y == pos.Y && game.pos.Z == pos.Z;
            }
        }


    }
}

