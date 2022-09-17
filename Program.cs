// Программа, которая на вход принимает 2 числа и проверяет, 
// является ли первое число квадратом второго
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = B * B;
Console.WriteLine("Результат " + result);

if (result == A)
{
Console.WriteLine($"A квадрат от B");
}
else
{
    Console.WriteLine($"Нет");
}
