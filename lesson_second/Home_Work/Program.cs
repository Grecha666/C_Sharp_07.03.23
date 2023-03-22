

/*
Задача 1.
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Напишите трехзначное число ");
int трехзначное_число = Convert.ToInt32(Console.ReadLine()); 
if(трехзначное_число > 99 && трехзначное_число < 1000)
{
    Console.WriteLine("Ура, твоё число трехзначное!");
    int убираем_первый_разряд = трехзначное_число / 10;
    int десяток = убираем_первый_разряд % 10;
    Console.WriteLine($"Десяток твоего числа равен {десяток}!");
}
else
{
    Console.WriteLine("Ты задал не трехзначное число!");
}

Задача 4.
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Напишите число от 1 до 7 ");
int число = Convert.ToInt32(Console.ReadLine()); 
if (число > 0 && число < 8)
{
    Console.WriteLine($"Число соответствует дню недели");
}
else
{
   Console.WriteLine($"Число не соответствует дню недели"); 
}
if (число == 6)
{
    Console.WriteLine($"Ура, это суббота!!!"); 
}
else if (число == 7)
{
    Console.WriteLine($"Ура, это воскресение!!!"); 
}
    else
    {
    Console.WriteLine($"Это будний день!!!"); 
    }


//Задача 2.
//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа

int three_digit_number = new Random().Next(100,1000);

int Function(int num)
{
    Console.WriteLine(num);
    int first_number = three_digit_number/100;
    int third_number = three_digit_number%10;
    return first_number*10 + third_number;
}
int result = Function(three_digit_number);
Console.WriteLine(result);

*/

//Задача 3.
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Напишите число ");
int число = Convert.ToInt32(Console.ReadLine()); 

while (число > 999)
{
    int результат_деления = число /= 10;
}

    int третяя_цифра = (число % 10);
    Console.WriteLine(третяя_цифра);

if (число >= 100 && число < 1000)
{
    int выводим_3_цифру = число % 10;
    Console.WriteLine(выводим_3_цифру);
}
else
{
    Console.WriteLine($"У твоего числа нет третьей цифры, напиши новое!");
}
