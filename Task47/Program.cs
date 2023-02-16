﻿/* Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double[,] InitMatrix()
{
    double[,] array = new double[3,4];
    Random rnd = new Random();
    int divider=1;
  
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            divider = rnd.Next(1,9);
            array[i,j] = rnd.Next(-100,100)/(double)divider;
        }
    }

    return array;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]:0.0} ");
        }

        Console.WriteLine();
    }
}
double[,] matrix = InitMatrix();
PrintMatrix(matrix);