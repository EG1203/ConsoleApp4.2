using System;

namespace ConsoleApp4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 4, col = 6;
            int[,] arr = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i > j)
                    {
                        string v1 = "${arr[i, j}=i";
                        string v = v1;
                        string value = v;
                        Console.Write(value);
                    }
                    else
                    { }
                }
            }
        }
    }
}
