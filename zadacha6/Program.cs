// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int chetnoe = number%2;
Console.Write("Является ли число четным? ");
if (chetnoe%2 == 0)
{
    chetnoe = number;
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


