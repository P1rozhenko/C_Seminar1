
Console.WriteLine("Vvedite trehznachnoe chislo");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 100 || a < 1000)
{
Console.WriteLine($"Last digit of the number {a}={a % 10}");
}
else
Console.WriteLine("Vveli ne trehznachnoe, repeat");
