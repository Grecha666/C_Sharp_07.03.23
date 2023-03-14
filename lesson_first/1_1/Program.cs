// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

Console.WriteLine("Напишите первое число: "); //"Write a first number: "
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напишите второе число: "); //"Write a second number: "
int number2 = int.Parse(Console.ReadLine()!);
if(number1 == number2*number2)
{
    Console.WriteLine("YES");

}
else 
{
    Console.WriteLine("NO");
}