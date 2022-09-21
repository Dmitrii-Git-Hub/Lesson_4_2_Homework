// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondDigit(int number)
{
    int secondDigit = (number/10)%10;
    return secondDigit;
}

Console.WriteLine("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вторая цифра это числа: " + SecondDigit(a));
