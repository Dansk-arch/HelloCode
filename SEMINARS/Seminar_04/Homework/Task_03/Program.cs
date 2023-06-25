/* Напишите программу, 
которая задаёт массив из 8 элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/

int GetNumber ()
{
    int Number = new Random().Next(0,100);
    return Number;
    
}

int [] ArrayCreate (int number)
{
    int [] Array = new int [number];
    return Array;
}   

void PrintArray (int [] array)
{
    Console.WriteLine ($"Our array [{string.Join(", ", array)}]");
}

int number = 8;
int [] Array = ArrayCreate(number);

for (int i = 0; i < number; i++)
{
    Array[i] = GetNumber();
}

PrintArray(Array);
