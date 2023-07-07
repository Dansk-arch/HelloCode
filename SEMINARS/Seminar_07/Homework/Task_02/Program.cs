/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

*/

int GetNumber (string decription)
{
    int number;
    Console.Write($"{decription} =>");

    while (true)
    {
        string temp = Console.ReadLine();
        if(int.TryParse(temp, out number))
        {
            return number;
        }
        Console.Write($"This number \"{temp}\" is not correct. Try again =>");
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

int SeachNumberInArray (int [,] array, int number)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    int count = 0;
    for (int i = 0; i <row; i++)
    {
        if (count > 0)
        {
            break;
        }
        for (int j = 0; j < column; j++)
        {
            if(array[i,j] == number)
            {
                count++;
            }

        }
    }
    
    return count;
    
}

void PrintArray (int[,] array)
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

int number = GetNumber("Input number for seach in array");
int [,] Array = CreateArray (3, 4, 0,5);
int NumberInArray = SeachNumberInArray(Array,number);
PrintArray(Array);
Console.WriteLine();
if(NumberInArray>0)
{
    Console.Write(number);
}
else
{
    Console.Write($"{number} ->такого числа в массиве нет");
}
