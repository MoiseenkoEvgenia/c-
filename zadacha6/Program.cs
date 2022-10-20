// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Является ли число четным? ");
if (number%2 == 0)
{ 
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}