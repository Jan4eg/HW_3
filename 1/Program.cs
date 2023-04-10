/*Задача 19

Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

int Read()
{
    int number;
    System.Console.Write("Введите 5-ти значное число: ");
    while (!int.TryParse(System.Console.ReadLine(), out number) || (number.ToString().Length != 5))
    {
        System.Console.Write("Введите 5-ти значное число: ");
    }
    return number;
}

int number = Read();

void NumbEntry(int number)
{
    string a = number.ToString();
    if ((a[0] == a[a.Length-1]) && a[1] == a[a.Length-2])
    {
        System.Console.WriteLine("Палиндром");
    }
    else
    {
    System.Console.WriteLine("Не палиндром");
    }
}

NumbEntry(number);

