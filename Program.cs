using System;

namespace Game2048
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] map = StartGame();
            DrawMap(map);
            ConsoleKeyInfo input;
            do
            {
                input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.UpArrow:
                        MoveUp(map);
                        break;
                    case ConsoleKey.DownArrow:
                        MoveDown(map);
                        break;
                    case ConsoleKey.LeftArrow:
                        MoveLeft(map);
                        break;
                    case ConsoleKey.RightArrow:
                        MoveRight(map);
                        break;
                }
                DrawMap(map);
            } while (input.Key != ConsoleKey.Escape);
        }

        private static void MoveRight(int[,] map)
        {

        }

        private static void MoveLeft(int[,] map)
        {
            bool Active = false;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (map[i, j] != 0)
                    {
                        int yPos = i;
                        while (yPos != 3)
                        {
                            if (map[yPos + 1, j] == map[yPos, j])
                            {
                                map[yPos + 1, j] *= 2;
                                map[yPos, j] = 0;
                                Active = true;
                            }
                            else if (map[yPos + 1, j] == 0)
                            {
                                map[yPos + 1, j] = map[yPos, j];
                                map[yPos, j] = 0;
                                Active = true;
                            }
                            else
                            {
                                break;
                            }
                            yPos++;
                        }
                    }
                }
            if (Active)
                AddRandNum(map);
        }

        private static void MoveDown(int[,] map)
        {
            bool Active = false;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (map[i, j] != 0)
                    {
                        int yPos = i;
                        while (yPos != 3)
                        {
                            if (map[yPos + 1, j] == map[yPos, j])
                            {
                                map[yPos + 1, j] *= 2;
                                map[yPos, j] = 0;
                                Active = true;
                            }
                            else if (map[yPos + 1, j] == 0)
                            {
                                map[yPos + 1, j] = map[yPos, j];
                                map[yPos, j] = 0;
                                Active = true;
                            }
                            else
                            {
                                break;
                            }
                            yPos++;
                        }
                    }
                }
            if (Active)
                AddRandNum(map);
        }

        private static void MoveUp(int[,] map)
        {
            bool Active = false;
            for (int i = 1; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (map[i, j] != 0)
                    {
                        int yPos = i;
                        while (yPos != 0) {
                            if (map[yPos - 1, j] == map[yPos, j])
                            {
                                map[yPos - 1, j] *= 2;
                                map[yPos, j] = 0;
                                Active = true;
                            }
                            else if (map[yPos - 1, j] == 0)
                            {
                                map[yPos - 1, j] = map[yPos, j];
                                map[yPos, j] = 0;
                                Active = true;
                            }
                            else
                            {
                                break;
                            }
                            yPos--;
                        }
                    }
                }
            if (Active)
                AddRandNum(map);
        }

        private static void AddRandNum(int[,] map)
        {
            Random random = new Random();
            while (true)
            {
                int xPos = random.Next(0, 4);
                int yPos = random.Next(0, 4);
                int num = random.Next(1, 2) * 2;
                if (map[xPos, yPos] == 0)
                {
                    map[xPos, yPos] = num;
                    break;
                }
            }
        }

        private static void DrawMap(int[,] map)
        {
            Console.Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static int[,] StartGame()
        {
            int[,] map = new int[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    map[i, j] = 0;
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                while (true)
                {
                    int xPos = random.Next(0, 4);
                    int yPos = random.Next(0, 4);
                    int num = random.Next(1, 2) * 2;
                    if (map[xPos, yPos] == 0)
                    {
                        map[xPos, yPos] = num;
                        break;
                    }
                }
            }
            return map;
        }

    }
}
