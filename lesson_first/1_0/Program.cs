// Напишите программу, которая на вход принимает число и выдаёт ег квадрат (число умноженное само на себя)

Console.WriteLine("Напишите число: "); //"Write a number: "
int number = int.Parse(Console.ReadLine()!); //int.Parse - преобразователь из строки в целочисленное значение (из string  в int)
Console.WriteLine(number*number);
