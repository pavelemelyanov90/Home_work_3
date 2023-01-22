// Задача 23: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int count = 1;

while(count <= number)
{
    if(count < number)
    {
        Console.Write($"{count * count * count}, ");
    }
    else
    {
        Console.Write($"{count * count * count}");
    }
    count++;
}