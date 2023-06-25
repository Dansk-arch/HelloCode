/*
Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int GetNumber (string decription)
{
    int number;
    Console.Write($"{decription} => ");

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

int GetLenghtNumber (int num)
{
    int countNumber=0;
    while(num>=1)
    {
        countNumber++;
        num = num /10;
    }
    return countNumber;
}

int [] GetArray (int Number, int lenghtNumber)
{
    int [] GetArrayNumber = new int[lenghtNumber]; 
    for (int i = lenghtNumber-1; i >= 0; i--)
    {
        GetArrayNumber[i] = Number%10;
        Number = Number/10;
    }   
    return GetArrayNumber;
}

int SumNumberInArray (int [] array)
{
    int sum = 0;
    int iteration = array.Length;
    for (int i = 0; i < iteration; i++)
    {
        sum=sum+array[i];
    }
    return sum;
}

int Number = GetNumber("Input number for multiplicate");
int Lenght = GetLenghtNumber(Number);
int [] Array = GetArray(Number, Lenght);
int sum = SumNumberInArray (Array);
Console.WriteLine ($"The sum of the digits of the number {Number} is {sum}");

