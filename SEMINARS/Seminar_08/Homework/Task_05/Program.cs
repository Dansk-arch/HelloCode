/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] CreateArray(int row, int column)
{

    int[,] array = new int[row, column];
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

int[,] CreateAutoArray(int[,] arrayNull)
{
    int row = arrayNull.GetLength(0);
    int column = arrayNull.GetLength(1);
    int[,] array = new int[row, column];
    int i = 0;
    int j = 0;
    while (i == 0 && j < column)
    {
        array[i, j] = i * row + j + 1;
        //Console.WriteLine($"Число {array[i, j]} добавлено в коориднату ({i},{j})");
        if (j == column - 1)
        {
            break;
        }
        else
        {
            j++;
        }
    }
    while (j == column - 1 && i < row - 1)
    {
        i++;
        array[i, j] = i + j + 1;
        //Console.WriteLine($"Число {array[i, j]} добавлено в коориднату ({i},{j})");
    }
    while (i == row - 1 && j > 0)
    {
        j--;
        array[i, j] = array[i, j + 1] + 1;
        //Console.WriteLine($"Число {array[i, j]} добавлено в коориднату ({i},{j})");
    }
    while (j == 0 && i > 1) // 1 магическое число
    {
        i--;
        array[i, j] = array[i + 1, j] + 1;
        //Console.WriteLine($"Число {array[i, j]} добавлено в коориднату ({i},{j})");
    }
    while (i == 1 && j < column - 2)
    {
        j++;
        array[i, j] = array[i, j - 1] + 1;
        //Console.WriteLine($"Число {array[i, j]} добавлено в коориднату ({i},{j})");
    }
    while (j == column - 2 && i < row-2)
    {
        i++;
        array[i, j] = array[i - 1, j] + 1;
        //Console.WriteLine($"Число {array[i, j]} добавлено в коориднату ({i},{j})");
    }
    while (i == row-2 && j > column -3)
    {
        j--;
        array[i, j] = array[i, j+1] + 1;
        //Console.WriteLine($"Число {array[i, j]} добавлено в коориднату ({i},{j})");
    }
    return array;
}

int[,] Array = CreateArray(4, 4);
int[,] ArrayAuto = CreateAutoArray(Array);
//PrintMatrixArray(Array);
//Console.WriteLine();
PrintMatrixArray(ArrayAuto);