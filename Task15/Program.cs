//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);

if (a <= 7 && a > 5)
{
    Console.WriteLine("Да");
}
if (a <= 5)
{
    Console.WriteLine("Нет");
}