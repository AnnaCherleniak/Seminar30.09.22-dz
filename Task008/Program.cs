// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.Write("Введите любое число от 10 до 99 - ");
string number = Convert.ToString(Console.ReadLine());
if(number[0] > number[1])
{
    Console.Write("Наибольшая цифра ");
    Console.WriteLine(number[0]);
}
else if(number[1] > number[0])
{
    Console.Write("Наибольшая цифра ");
    Console.WriteLine(number[1]);
}
