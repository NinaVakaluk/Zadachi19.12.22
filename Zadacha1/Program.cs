Console.WriteLine("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine()!);
int result = number % 100;
int itog = result / 10;
Console.WriteLine($"{number}-> {itog}");
if (number > 99 && number <= 999)
{
    Console.WriteLine("Число является трехзначным");
}
else
{
    Console.WriteLine("Число не является трехзначным");
}