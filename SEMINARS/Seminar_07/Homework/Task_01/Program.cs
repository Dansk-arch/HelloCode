/*
Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double [,] CreateArray (int row, int column)
{
    Random rand = new Random ();
    double [,] array = new double [row, column];
    for (int i = 0; i <row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i,j] = Math.Round(rand.NextDouble(),2);

        }
    }
    return array;
}


void PrintArrayDouble (double[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);

    for (int i = 0; i <row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array[i,j]}\t");

        }
        Console.WriteLine();
    }
}


double [,] Array = CreateArray (3, 4);
PrintArrayDouble(Array);