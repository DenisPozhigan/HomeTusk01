// Домашняя задача №2
Console.WriteLine("Введите первое число");
int a = int.Parse (Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse (Console.ReadLine());

if (a>b)
{
    Console.WriteLine("Число a больше числа b");
}
if (a==b)
{
    Console.WriteLine("Число b равно числу а");
}
else
{
    Console.WriteLine("Число b больше числа a");
}