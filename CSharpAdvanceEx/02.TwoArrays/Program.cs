using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            int cols = 4;
            int count = 1;
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; i++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
            
        }
    }

