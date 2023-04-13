// Напишите программу, которая принимаетна вход число и выдаёт количество цифр в числе

int GetUserNumber()
{
    Console.WriteLine("Напиши своё число: ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int CountNumber(int n)
{
    int count = 0;
    while (n > 0)
    {
        n = n/10;
        count++;
    }
    return count;
}
int number = GetUserNumber();
int digit = CountNumber(number);
Console.WriteLine("Количество цифр в твоём числе равно " + digit);

