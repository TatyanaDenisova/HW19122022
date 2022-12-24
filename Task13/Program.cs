//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
int b = 0;

while(a<99999)
{
if(a <= 99)
{
  Console.WriteLine("третьей цифры нет");
  return;
}
if(a<=999)
{
  b = a % 10;
  Console.WriteLine(b);
  return;
}
if(a<=9999)
{
  b = a/10 % 10; 
  Console.WriteLine(b); 
  return;
}
if(a<=99999)
{
  b = a/100 % 10; 
  Console.WriteLine(b); 
  return;
}
}
