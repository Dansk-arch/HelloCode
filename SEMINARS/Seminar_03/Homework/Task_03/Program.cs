/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber ()  
{
    Console.WriteLine("Введите число");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

int [] FindSqrNumber (int numb)
{
    int [] ArraySqrNumber = new int [numb];
    
    int pow =3;
    for (int i = 0; i < numb; i++)
    {
        ArraySqrNumber[i]=Convert.ToInt32(Math.Pow(i+1,pow));
    }
    return ArraySqrNumber;
}

void Print (int [] collection, int numb)
{
    for (int i = 0; i < numb; i++)
    {
        Console.Write($"{collection[i]} ");
    }
}
int Number = GetNumber();
int [] Array = FindSqrNumber(Number);
Print(Array,Number);