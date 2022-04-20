// программа, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int b = 7;
int c = 21;

if ((a % b == 0) & (a % c == 0))
{
    Console.WriteLine("Кратно двум числам");
}
else 
{
    Console.WriteLine($"не кратно числу {a % b} или {a % c}");
}   