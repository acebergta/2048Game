using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2048
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] map = StartGame();
            
        }

        private static int[,] StartGame()
        {
            int[,] map = new int[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    map[i, j] = 0;

            return map;
        }
    }
}
