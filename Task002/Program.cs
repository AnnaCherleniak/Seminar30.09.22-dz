﻿// По заданному номеру дня недели ввести его название
Console.WriteLine("Введите номер дня недели ");
string day = Convert.ToString(Console.ReadLine());
if(day == "1")
{
    Console.WriteLine("Monday");
}
else if(day == "2")
{
    Console.WriteLine("Tuesday");
}
else if (day == "3")
{
    Console.WriteLine("Wednesday");
}
else if (day == "4")
{
    Console.WriteLine("Thursday");
}
else if(day == "5")
{
    Console.WriteLine("Friday");
}
else if(day =="6")
{
    Console.WriteLine("Saturday");
}
else if(day == "7")
{
    Console.WriteLine("Sunday");
}