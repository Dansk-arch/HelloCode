/*
Сформируйте двухмерный массив из неповторяющихся двузначных чисел.
*/

int[,] CreateArray(int row, int column, int min, int max)
{
    int[] array = new int[row * column];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(min, max + 1);

        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    Console.WriteLine($"значение {array[i]} с индексом {i} равно {array[j]} с индексом {j} ");
                    Console.WriteLine($"значение {array[i]} с индексом {i} меняется");
                    array[i] = rand.Next(min, max + 1);
                    Console.WriteLine($"на значение {array[i]} с индексом {i}");
                    j = 0;
                    i = 0;
                }
            }
        }
    }
    int[,] arrayMatrix = new int[row, column];
    int size = array.Length;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arrayMatrix[i, j] = array[i * row + j];
        }
    }
    return arrayMatrix;


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

string PrintArray(int[] array)
{
    return string.Join(", ", array);
}


int min = 10;
int max = 99;
int row =3;
int column = 3;
if (row*column<(max-min+1))
{
    int[,] array = CreateArray(row, column, min, max);
    PrintMatrixArray(array);
}
else
{
    Console.WriteLine("Unique value less than the size array");
}
