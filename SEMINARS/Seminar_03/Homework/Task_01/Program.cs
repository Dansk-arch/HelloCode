/* Задача 19
Напишите программу, которая 
принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int GetNumber ()  
{
    Console.WriteLine("Введите пятизначное число");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
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
void CheckPolindrom (int [] collection, int lenghtCollection)
{
    int zonecheck = lenghtCollection/2;
    int count =0;
    for (int i = 0; i < zonecheck; i++)
    {
        if(collection[i]==collection[lenghtCollection-1-i])
        {
            //Console.WriteLine(collection[i]);
            //Console.WriteLine(collection[lenghtCollection-1-i]);
            count++;
        }
    }
    if (count==zonecheck)
    {
        Console.WriteLine("Число полиндром");
        //Console.Write(count);
    }
    else
    {
        Console.Write("Число НЕ полиндром");
        //Console.Write(count);
    }
}

int Number = GetNumber();
int Numberlengt = 5; //значения чисел "пятизначное число" по условию задачи
int [] Array = GetArray(Number, Numberlengt);
CheckPolindrom(Array,Numberlengt);