// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// Палиндром - число пе́ревертень 

/*
void CreateArray(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(0,10);
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int [] array = new int[5]; 

CreateArray(array);
PrintArray(array);


if(array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine("Вау, твоё число палиндром! ПОВЕЗЛО!");
}
else
{
    Console.WriteLine("Не палиндром(");
}
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
Console.WriteLine("Напишите значения для x1: ");
int x1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите значения для y1: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите значения для z1: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите значения для x2: ");
int x2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите значения для y2: ");
int y2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите значения для z2: ");
int z2 = int.Parse(Console.ReadLine()!);

double Length (int x1, int y1, int x2, int y2, int z1, int z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2)),3);
}

Console.WriteLine(Length(x1, y1, x2, y2, z1, z2));
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void SumOfSquares(int number)
{
    int index = 1;
    while(index <= number)
    {
        Console.WriteLine(Math.Pow(index,3));
        index++;
    }
}    

Console.WriteLine("Напишите своё число: ");
int num = int.Parse(Console.ReadLine()!);
SumOfSquares(num);