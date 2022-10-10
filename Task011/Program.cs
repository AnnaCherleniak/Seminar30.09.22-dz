// Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите число ");
double n = Convert.ToDouble(Console.ReadLine());
if(n < 100)
{
    Console.WriteLine("НЕТ");

}
else 
{
    Console.WriteLine(n);
}
string number = Convert.ToString(Console.ReadLine());
int size = number.Length;
int i = size - 3;
Console.WriteLine(number[i]);