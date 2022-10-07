// Показать четные числа от 1 до N
double i = 1;
Console.Write("Введите число N");
double N = Convert.ToDouble(Console.ReadLine());
while (i <= N)
{
    if(i % 2 == 0)
        Console.WriteLine(i);
    i = i + 1;
}