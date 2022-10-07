// Выявить, кратно ли число заданному, если нет, вывести его остаток

Console.WriteLine("Введите делимое");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите делитель");
double n = Convert.ToDouble(Console.ReadLine());
if (a % n == 0)
{
    Console.WriteLine("Кратно");
}
else 
{
    Console.WriteLine(a % n);
}