/*
Напишите программу, 
которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int GetNumber ()  
{
    Console.WriteLine("Чтобы понять выходной ли сегодня - введите цифру, обозначающую день недели");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}
string GetWeekEnd (int num)
{
switch(num)
{
    case 1: return "Сегодня не выходной :(";
    case 2: return "Сегодня не выходной :(";
    case 3: return "Сегодня не выходной :(";
    case 4: return "Сегодня не выходной :(";
    case 5: return "Сегодня не выходной, но он скоро";
    case 6: return "Да, сегодня выходной";
    case 7: return "Да, сегодня выходной";
    default: return "Вы ввели номер не соответствующий пониманию нумерации дней в неделе";
}
}
void WriteText (string text)
{
    Console.WriteLine(text);
}
WriteText(GetWeekEnd(GetNumber()));