// Задача 08
Console.WriteLine("Введите число:");
int j = int.Parse(Console.ReadLine());

for (int i = -j; i < j; i++)
{
    if (i % 2 == 0)
    Console.WriteLine(i);
}