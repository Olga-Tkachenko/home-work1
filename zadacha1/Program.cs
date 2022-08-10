// напишите программу которая на вход принимает два числа и выдает какое число больше, а какое меньше.
// Пример: a=5, b=7 max=7
Console.WriteLine("Введите первое число");
string numberString1 = Console.ReadLine();
int numberA = int.Parse(numberString1);
Console.WriteLine("Введите второе число");
string numberString2 = Console.ReadLine();
int numberB = int.Parse(numberString2);
if (numberA>numberB)
{
    Console.WriteLine("max " + numberA);
}
else
{
    Console.WriteLine("max " + numberB);
}