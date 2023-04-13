//Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А

int SumNumber(int number) 
{
    int sum_all = 0;
    for(int i = 1; i <= number; i++)
    sum_all += i;

    return sum_all;

}

Console.WriteLine("Напиши число: ");
int val = int.Parse(Console.ReadLine()!);
int result = SumNumber(val);
Console.WriteLine(result);