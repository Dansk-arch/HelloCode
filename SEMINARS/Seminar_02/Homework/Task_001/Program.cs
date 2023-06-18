/*
Напишите программу, 
которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int GetNumber ()  
{
    Console.WriteLine("Введите трехзначное число");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

void WriteNumber (int num)
{
    Console.WriteLine(num);
}

int CutNumber (int num)
{
    return  num /10%10;
}

WriteNumber(CutNumber(GetNumber()));