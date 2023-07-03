/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

*/

int QuantityNumber (string decription)
{
    int number;
    Console.Write($"{decription}:");

    while (true)
    {
        string temp = Console.ReadLine();
        if(int.TryParse(temp, out number))
        {
            return number;
        }
        else
        {
            Console.Write($"This number \"{temp}\" is not correct. Try again =>");
        }  
    }
}

int [] Array (int size,string decription)
{
    int [] array = new int [size];
    int count = size;
    for( int i=0; count>0; i++)
    {
        Console.Write($"{decription} -> {count}: введите число ");
        int number;
        while (true)
        {
            string temp = Console.ReadLine();
            if(int.TryParse(temp, out number))
            {
                array[i]=number;
                break;
            }
            else
            {
                Console.Write($"This number \"{number}\" is not correct. Try again =>");
            }  
        }
        count--;
    }
    return array;
}

string PrintArrayInt (int [] array)
{
    return string.Join(", ", array);
}

int FindPositiveNumbers (int [] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if(item>0)
        {
            count++;
        }
    }
    return count;
}


int size = QuantityNumber("Введите количество чисел, которые хотите проанадизировать");
int [] array = Array(size, "Осталось ввести чисел:");
Console.WriteLine(PrintArrayInt(array));
Console.Write(FindPositiveNumbers(array));