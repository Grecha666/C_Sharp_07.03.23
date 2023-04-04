//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот

Console.WriteLine("Напишите количество элементов в массиве: ");
int count = int.Parse(Console.ReadLine()!);
Console.WriteLine("Начало диапазона: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Конец диапазона: ");
int b = int.Parse(Console.ReadLine()!);

int[] MakeArray(int c, int m, int n)
{
    int[] array = new int [c];

    for (int i=0; i < array.Length; i++)
    array[i] = new Random().Next(m, n+1);
    return array;
}

void PrintArray(int[] arr)
{
    for (int i=0; i < arr.Length; i++)
    Console.Write($"{arr[i]} ");
}


void MyFunction(int[] arr) 
{
    for (int i=0; i < arr.Length; i++)
    arr[i]*=-1;

}

int[] array = MakeArray(count, a, b);
PrintArray(array);
Console.WriteLine();
MyFunction(array);
PrintArray(array);