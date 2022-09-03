using System;

namespace Aula2POO.Classes
{
    class Map
    {
        public string[,] Array2D { get; set; }
        public void AddJewel(Jewel jewel)
        {
            Array2D[jewel.Position.X, jewel.Position.Y] = "";
        }

        public void AddObstacle(Obstacle obstacle)
        {
            Array2D[obstacle.Position.X, obstacle.Position.Y] = "";
        }

        public void ClearSpace(int x, int y)
        {
            Array2D[x, y] = "--";
        }

        public void Print()
        {
            int rowLength = Array2D.GetLength(0);
            int colLength = Array2D.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    if (String.IsNullOrEmpty(Array2D[i, j]))
                    {
                        Console.Write(string.Format("{0} ", "--"));
                    } else
                    {
                        Console.Write(string.Format("{0} ", Array2D[i, j]));
                    }
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
        }
    }
}
