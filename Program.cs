/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


/*
Console.Write("Введите пятизначное число: ");
var numb = Console.ReadLine();
int length = numb.Length;
if (length == 5)
{
    if (numb[0] == numb[4] && numb[1] == numb[3])
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Вы ввели неверное число");
}
*/

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Write("Введите координату для x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату для y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату для z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату для x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату для y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату для z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"Расстояние между точками A:({x1}, {y1}, {z1}) и B:({x2}, {y2}, {z2}) равно: {Math.Round(d, 2)}");