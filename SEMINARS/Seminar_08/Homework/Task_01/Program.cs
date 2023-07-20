/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

void PrintMatrixArray(int[,] array)
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

int[,] SortArray(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    
    for (int c = 0; c < row; c++)
    {
        for (int i = 0; i < column-1; i++)
        {
            int maxPosicion = i;
            
            for (int j = i + 1; j < column; j++)
            {
                if (array[c, maxPosicion] < array[c, j])
                {
                    maxPosicion = j;
                    
                } 
            }
                //Console.WriteLine($"Буферное значение {array[c, i]}");
                int temp = array[c, i];
                
                //Console.WriteLine($"Вместо буферного значения {array[c, i]} ({c},{i}) в массив записывается {array[c, maxPosicion]} ({c},{maxPosicion})");
                array[c, i] = array[c, maxPosicion];
                
                //Console.WriteLine($"На место максимального значения с координатами ({c},{maxPosicion}) запиcывается {temp}");
                array[c, maxPosicion] = temp;
        }
    }
    return array;
}

int[,] array = CreateArray(3, 5, 1, 10);
PrintMatrixArray(array);
Console.WriteLine();
PrintMatrixArray(SortArray(array));
