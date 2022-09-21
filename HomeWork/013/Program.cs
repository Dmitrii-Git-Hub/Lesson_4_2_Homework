// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdDigit(int number)
{
    int thirdDigit = number;
    while (number / 1000 > 0)
    {
        number = number / 10;
        thirdDigit = number;
    }
    return thirdDigit % 10;
}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a / 100 > 0)
{
    Console.WriteLine("Третья цифра этого числа: " + ThirdDigit(a));
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}
