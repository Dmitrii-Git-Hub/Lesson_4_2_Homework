// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
void WeekDay(int a)
{
    if (a > 5)
    {
        Console.WriteLine("Да!");
    }
    else 
    {
        Console.WriteLine("Нет!");
    }
}

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Это выходной? ");
WeekDay(a);
