/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int SummEvenNumbers (int [] array)
{
    int summ = 0;
    for (int i=0; i <array.Length-1;i++)
    {
        if (i%2!=0)
        {
            summ+=array[i];
        }
    }
    return summ;
}

int [] Array = CreateArray(5,-9,9);
int summ=SummEvenNumbers(Array);

Console.Write($"In array [{PrintArray(Array)}] ->{summ}");