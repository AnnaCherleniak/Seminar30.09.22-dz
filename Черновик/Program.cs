Console.Write("Введите трехзначное число ");
string number = Convert.ToString(Console.ReadLine());
int max = number[0];
if(number[1] > max)
{
    max = number[1];
}
if(number[2] > max)
{
    max = number[2];
}
Console.WriteLine(max);