int a = new Random().Next(10, 99);
Console.WriteLine(a);
int b = a / 10;
int c = a % 10;

if (b > c)
{
    Console.WriteLine($"Наибольше число {b}");
}
else
{
    Console.WriteLine($"Наибольше число {c}");
}