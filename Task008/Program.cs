// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.

Console.Write("Введите трехзначное число ");
string number = Convert.ToString(Console.ReadLine());
int size = 3;
int i = 0;
int max_number = number[i];
Console.WriteLine(max_number);
