/*
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] CreateArray(int row, int column, int min, int max)
{
    Random rand = new Random();
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rand.Next(min, max + 1);

        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array[i, j]}\t");

        }
        Console.WriteLine();
    }
}

int SeachMinSummRowInMatrix (int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int [] arraySummRow = new int[rows];
    int summ=0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            summ=summ+array[i,j];
        }
        arraySummRow[i]=summ;
    }
    int min = arraySummRow[0];
    for (int i = 1; i < arraySummRow.Length; i++)
    {
        if (min>arraySummRow[i])
        {
            min=arraySummRow[i];
        }
    }
    
    return min;

}

int[,] array = CreateArray(4,4, 0,10);
PrintArray(array);
Console.WriteLine(SeachMinSummRowInMatrix(array));
