// Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел.
// например 2, 3, 7, max 7
Console.WriteLine("Введите первое число");
string numberString1 = Console.ReadLine();
int numberA = int.Parse(numberString1);
Console.WriteLine("Введите второе число");
string numberString2 = Console.ReadLine();
int numberB = int.Parse(numberString2);
Console.WriteLine("Введите третье число");
string numberString3 = Console.ReadLine();
int numberC = int.Parse(numberString3);
int max=numberA;
if (numberA>max) max=numberA;
if (numberB>max) max=numberB;
if (numberC>max) max=numberC;
Console.Write("max = ");
Console.WriteLine(max);
