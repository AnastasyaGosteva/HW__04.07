Console.Write("Введите первое число: number1 = ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: number2 = ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите первое число: number3 = ");
int number3 = int.Parse(Console.ReadLine());
int max = 0;
if (number1<number2)
{
    max=number2;
}
else
{
    if (number2<number3)
    {
        max=number3;
    }
    else
    {
        if (number3<number1)
        {
            max=number1;
        }
    }
}
Console.WriteLine($"Максимальное число среди чисел {number1}, {number2}, {number3} равно "+max+".");