/*void Insert(int a)
{
    Console.WriteLine("Вставить" + a);
}*/

int CreatNumber()
{
    return new Random().Next(10,100);
}

int MaxDigit(int number)
{
    int Decimal = number/10;
    int ed = number % 10;

    if (Decimal >= ed)
    {
        return Decimal;
    }
    else
    {
        return ed;
    }
}

int a = CreatNumber();
Console.WriteLine(a);
Console.WriteLine(MaxDigit(a));