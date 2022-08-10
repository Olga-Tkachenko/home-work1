// Напишите программу, которая на вход принимает число и выдает, является ли число чётным (делится оно
// на 2 без остатка). Например 4 - да
Console.WriteLine("Введите число");
string? numberString1 = Console.ReadLine();
int numberA = int.Parse(numberString1!);
if (numberA %2 == 0) 
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}
