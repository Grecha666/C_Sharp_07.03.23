// Напишите программу, которая принимает на вход трехзначное число, и на выходе показывает последнюю цифру этого числа

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num % 10;
}

int three_digit_number = new Random().Next(100,1000 );

int result = TakeNum(three_digit_number);
Console.WriteLine(result);

