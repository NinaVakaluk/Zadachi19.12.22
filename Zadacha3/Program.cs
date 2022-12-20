Console.WriteLine("Введите номер дня недели:");
int number = int.Parse(Console.ReadLine()!);
if (number == 6 || number == 7)
{
    Console.WriteLine($"{number}->Да");
}
if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
{
    Console.WriteLine($"{number}->Нет");
}
if (number < 1 || number > 7)
{
    Console.WriteLine($"Дня недели не существует");
}