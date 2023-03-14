// Напишите программу, которая будет выдавать название дня недели по заданному номеру

Console.WriteLine("Напишите своё число (от 1 до 7): "); //"Write a first number: "
int number = int.Parse(Console.ReadLine()!);
if(number == 1)
{
    Console.WriteLine("ПОНЕДЕЛЬНИК");
}
else if(number == 2)
{
    Console.WriteLine("ВТОРНИК");
}
else if(number == 3)
{
    Console.WriteLine("СРЕДА");
}
else if(number == 4)
{
    Console.WriteLine("ЧЕТВЕРГ");
}
else if(number == 5)
{
    Console.WriteLine("ПЯТНИЦА");
}
else if(number == 6)
{
    Console.WriteLine("СУББОТА");
}
else if(number == 7)
{
    Console.WriteLine("ВОСКРЕСЕНЬЕ");
}
else 
{
    Console.WriteLine("Такого дня нет, глупыш");
}