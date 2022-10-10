// Проверить кратно ли число 7 и 23

Console.WriteLine ("Введите число");
double n = Convert.ToDouble(Console.ReadLine());
if (n % 7 == 0)
{
    Console.WriteLine("Число кратно 7");
}
else
{
    Console.WriteLine("Число не кратно 7");
}
if (n % 23 == 0)
{
    Console.WriteLine("Число кратно 23");
}
else
{
    Console.WriteLine("Число не кратно 23");
}
