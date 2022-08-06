// 1. Напишите программу, которая на вход принимает два числа и 
//проверяет, является ли первое число квадратом второго.
//a = 25,b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

Console.WriteLine("vvedite pervoe chislo");
int a = Convert.ToInt32(Console.Readline());
Console.Writeline("vvedite vtoroe chislo");
int b = Convert.ToInt32(Console.Readline());
if (b*b==a)
{
Console.WriteLine("YAVLYAETSYA");
}
else 
{
Console.WriteLine("Ne yavlaetsa kvadratom");
}