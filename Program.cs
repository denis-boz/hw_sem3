/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

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
