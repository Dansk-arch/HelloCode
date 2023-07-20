/*
Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

bool CheckMatrixMultiplication(int[,] arrayA, int[,] arrayB)
{

    int columnA = arrayA.GetLength(1);
    int rowB = arrayB.GetLength(0);
    if (columnA == rowB)
    {
        return true;
    }
    else
    {
        return false;
    }
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

int[,] MultiplicateMatrix(int[,] arrayA, int[,] arrayB)
{
    int rowA = arrayA.GetLength(0);
    int columnA = arrayA.GetLength(1);
    int rowB = arrayB.GetLength(0);
    int columnB = arrayB.GetLength(1);
    int[,] matrix = new int[rowA, columnB];
    int result = 0;
    for (int i = 0; i < rowA; i++)
    {
        for (int j = 0; j < columnA; j++)
        {
            for (int k = 0; k < columnB; k++)
            {
                result=arrayA[i,j]*arrayB[j,k];
                matrix[i,k]=matrix[i,k]+result;
            }
        }
    }

    return matrix;
}

int m = 2;
int l = 3;
int ll = 3;
int n = 2;

int[,] arrayA = CreateArray(m, l, 0, 10);
PrintMatrixArray(arrayA);
Console.WriteLine();
int[,] arrayB = CreateArray(ll, n, 0, 10);
PrintMatrixArray(arrayB);
Console.WriteLine();

if (CheckMatrixMultiplication(arrayA, arrayB) == true)
{
    int[,] arrayMulti = MultiplicateMatrix(arrayA, arrayB);
    Console.WriteLine("__________");
    PrintMatrixArray(arrayMulti);
}
else
{
    Console.WriteLine($"Matrix parameters ({m}x{l},{ll}x{n}) prevent multiplication");
}