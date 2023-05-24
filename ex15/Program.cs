//Напишите программу, которая принимает на вход цифру, обозначающую 
//день недели, и проверяет, является ли этот день выходным.

void FindWeekendTrue(int a)
{
if (a>7 || a<1)
{
    Console.WriteLine("Такого дня недели нет!");
}
else
{
switch (a)
{
    case (1):
    Console.WriteLine("нет");
    break;
    case (2):
    Console.WriteLine("нет");
    break;
    case (3):
    Console.WriteLine("нет");
    break;
    case (4):
    Console.WriteLine("нет");
    break;
    case (5):
    Console.WriteLine("нет");
    break;
    case (6):
    Console.WriteLine("Да");
    break;
    case (7):
    Console.WriteLine("Да");
    break;
}
}
}
Console.WriteLine("Введите день недели, программа определит, выходной ли это." );
int wdtrue = int.Parse(Console.ReadLine());
FindWeekendTrue(wdtrue);
