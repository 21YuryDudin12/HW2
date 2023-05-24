//Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

void FindTherdDigit (int num)
{
    int resnum = 0;
    if (num <100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else 
    {
        string strnum = num.ToString();
        string shortstrnum = strnum.Substring(0, 3);
        resnum = (int.Parse(shortstrnum) % 10);
        Console.WriteLine(resnum);
    }
}
Console.WriteLine("Введите число в пределах int");
int digit = int.Parse(Console.ReadLine());
Console.WriteLine("Третья цифрав числа равна: ");
FindTherdDigit(digit);
