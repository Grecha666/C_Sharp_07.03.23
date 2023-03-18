// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру этого числа

/*
int two_digit_number = new Random().Next(10,100);
int result = TakeNum(two_digit_number);

int TakeNum(int num)
{
    Console.WriteLine($"Задаём рандомное двузначное число, пусть оно будет равно {num}");
    int unit = num % 10;
    int dozen = num / 10;
    int max = unit;
   
    if (max < dozen) 
    max = dozen;
    Console.WriteLine($"Самая большая цифра этого числа равна {max}");
    return max;
}
*/

//Версия Ивана

int num = GenerateNumber();
PrintNumber(num);
int digit1 = GetFirstDigit(num);
int digit2 = GetSecondDigit(num);
int max = FindMax(digit1, digit2);
PrintNumber(max);

int GenerateNumber()
{
    int number = new Random().Next(10,100);
    return number;
}
int GetFirstDigit(int n)
{
    return n/10;
}
int GetSecondDigit(int n)
{
    return n%10;
}
int FindMax(int n1, int n2)
{
    if(n1 > n2)
    {
        return n1;
    }
    return n2;
}
void PrintNumber(int n)
{
    Console.WriteLine("Your number is: " + n);
}