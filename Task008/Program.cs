// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.

int number = new Random().Next(10,99);
string namber = Convert.ToString(Console.ReadLine());
int size = 2;
int i = 0;
int max = number[0];
while(i < size)
{
    if(number[i] > max)
    {
        max = number[i];
    }
    i = i + 1;
}
