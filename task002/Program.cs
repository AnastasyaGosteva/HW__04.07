Console.Write("Введите первое число: number1 = ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: number2 = ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Большее число между числами {number1} и {number2} является " + number1, number1, number2+".");
    Console.Write($"Меньшее, соответственно, " + number2);
}
else
{
    Console.WriteLine($"Большее число между числами {number1} и {number2} является " + number2, number1, number2+".");
    Console.Write($"Меньшее, соответственно, " + number1);
}