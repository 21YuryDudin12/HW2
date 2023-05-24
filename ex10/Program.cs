//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
void FindSecNumb(int number)
{
int a = (number / 10) % 10;
Console.WriteLine(a);
}
int b = int.Parse(Console.ReadLine());
FindSecNumb(b);



