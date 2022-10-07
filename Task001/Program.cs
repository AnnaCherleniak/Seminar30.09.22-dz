// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите первое число");
double f = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double s = Convert.ToDouble(Console.ReadLine());
if(f == s * s)
{
    Console.WriteLine("является");
}
else
{
    Console.WriteLine("не является");
}