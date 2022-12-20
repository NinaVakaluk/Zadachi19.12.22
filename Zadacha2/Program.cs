Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
if (number>100 && number<= 999)
{
    int result = number%100;
    int itog= result/10;
    Console.WriteLine($"{number}-> {itog}");
}
if (number>1000 && number<= 9999)
{
    int result = number%100;
    int itog= result/10;
    Console.WriteLine($"{number}-> {itog}");
}
if (number>10000 && number<= 99999)
{
    int result = number%1000;
    int itog= result/100;
    Console.WriteLine($"{number}-> {itog}");
}
if (number<99)
{
    
    Console.WriteLine($"Третьей цифры нет");
}