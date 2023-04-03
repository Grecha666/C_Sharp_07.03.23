// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N

int GetUserNumber()
{
    Console.WriteLine("Напиши своё число: ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int MyltiplyNumbers(int n)
{
    int multi = 1;
    for(int i = 1; i <= n; i++)
    {
        multi = multi * i;
    }
    return multi;
}

int number = GetUserNumber();
int new_number = MyltiplyNumbers(number);
Console.WriteLine("Произведение цифр в твоём числе равно " + new_number);