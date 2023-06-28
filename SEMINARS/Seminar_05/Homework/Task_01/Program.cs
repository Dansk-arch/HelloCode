/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int [] CreateArray (int size, int min, int max)
{
    int [] array = new int [size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min,max+1);
    }
    return array;   
}

string PrintArray (int [] array)
{
    return string.Join(", ", array);
}

int CountEvenNumbers (int [] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item%2==0)
        {
            count++;
        }
    }
    return count;
}
int [] Array = CreateArray(5,100,999);
int count = CountEvenNumbers(Array);
Console.Write($"In array [{PrintArray(Array)}] ->{count}");