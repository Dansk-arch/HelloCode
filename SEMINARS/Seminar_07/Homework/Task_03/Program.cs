/*
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void PrintArrayMatrix (int[,] array)
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

int [,] CreateArray (int row, int column, int min, int max)
{
    Random rand = new Random ();
    int [,] array = new int [row, column];
    for (int i = 0; i <row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i,j] = rand.Next(min, max+1);

        }
    }
    return array;
}

double [] GetAvrSummInColumn (int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    double summ = 0;
    double [] AvrArray = new double [column];
    for (int j = 0; j <column; j++)
    {
        for (int i = 0; i < row; i++)
        {
            summ=summ+array[i,j];
        }
        AvrArray[j]=Math.Round(summ/row,2);
        summ=0;
    }
    return AvrArray;
}

string PrintArray (double [] array)
{
    return string.Join("; ", array);
}


int [,] Array = CreateArray (3, 4, 0,10);
PrintArrayMatrix(Array);
Console.WriteLine();
double [] ArrayAvrInColumn = GetAvrSummInColumn(Array);
Console.Write(PrintArray(ArrayAvrInColumn));