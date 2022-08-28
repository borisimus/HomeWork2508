/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */
Console.Clear();
Console.Write("Введите пятизначное число: ");
string Number = Console.ReadLine();

void Palindrom (string Number)
{
    if (Number[0] == Number[4] || Number[2] == Number[3])   
    {
        Console.WriteLine("Число является палиндромом -> ДА");
    }
    else
    {
        Console.WriteLine("Число является палиндромом -> НЕТ");
    }
}
Palindrom(Number);