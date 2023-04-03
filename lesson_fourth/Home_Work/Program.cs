//Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int GetUserNumber()
{
    Console.WriteLine("Напиши своё число: ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int MyltiplyNumbers(int n)
{
    int count = 0;
    while (n > 0)
    {
        int digit = n%10;
        count = count + digit;
        n = n/10;
    }
    return count;
}

int number = GetUserNumber();
int new_number = MyltiplyNumbers(number);
Console.WriteLine("Сумма цифр в твоём числе равно " + new_number);
*/

//Задача 25. Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.WriteLine("Напиши первое число");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напиши второе число");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine(Math.Pow(a, b));
*/

//Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] array = new int[8];

for (int i = 0; i < array.Length; i++)
 {
    array [i] = new Random().Next(11);
    Console.Write(Method (i) + " ");
 }

int Method (int a)
{
    return array[a];
}

 