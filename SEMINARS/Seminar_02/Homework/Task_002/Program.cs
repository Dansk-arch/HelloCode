/*
 Напишите программу, 
 которая выводит третью цифру заданного числа 
 или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int GetNumber ()  
{
    Console.WriteLine("Введите число");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

int GetPosicion ()  
{
    Console.WriteLine("Номер цифры, которую необходимо показать");
    int Posicion = Convert.ToInt32(Console.ReadLine())-1;  //-1 для определения индекса т.к. они с 0
    return Posicion;
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
    for (int i = lenghtNumber-1; i != 0; i--)
    {
        GetArrayNumber[i] = Number%10;
        Number = Number/10;
    }
    return GetArrayNumber;
}

void WriteNumber (int num)
{
    Console.WriteLine(num);
}

int Number = GetNumber();
int Lenght = GetLenghtNumber(Number);
int Posicion = GetPosicion(); 
if (Lenght>=Posicion+1)
{
    int [] ArrayNumber = GetArray(Number, Lenght);
    WriteNumber(ArrayNumber[Posicion]);
}
else
{
    Console.Write($"{Posicion+1} цифры в числе нет");
}