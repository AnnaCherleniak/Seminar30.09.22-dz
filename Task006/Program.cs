// Показать последнюю цифру трехзначного числа

Console.Write("Введите трехзначное число ");
string namber = Convert.ToString(Console.ReadLine());
int size = 3;
int i = size - 1;
Console.WriteLine(namber[i]);