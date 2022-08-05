//Напишите программу, которая 
// 1. на вход принимает число и 
// 2. выдаёт его квадрат (число умноженное на само себя).
//Например: 
//4 -> 16
//-3 -> 9 
//-7 -> 49

Console.Write("Vvedite tseloe chislo: ");
int num = Convert.ToInt32(Console.ReadLine()); //-2 147 483 648 to 2 147 483 647
int square = num * num;
Console.Write($"Kvadrat chisla {num} = {square}");

