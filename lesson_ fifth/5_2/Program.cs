// Задайте массив. Напишите программу, которая определяет присутствует ли заданное число в массиве

Console.WriteLine("Напишите размер нового массива: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите начало диапазона массива: ");
int start = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите конец диапазона массива: ");
int stop = int.Parse(Console.ReadLine()!);


void Print(int[] arr)  //выводящая функция
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
     
}
*/
int[] NewMass(int size, int from, int to)  //заполняющая функция
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
        return arr;
}

bool FindNumber (int[] arr, int n)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == n)
        return true;

    }
    return false;
}

int[] mass = NewMass(num, start, stop); //возвращаем одномерный массив, 'сложили в коробочку информацию о массиве'
Console.Write("Новый массив: ");   
Print(mass); 

Console.WriteLine();
Console.Write("Введите проверяемое число: ");  
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(FindNumber(mass, number));



