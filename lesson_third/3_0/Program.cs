// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X не равен 0 или Y не равен 0 и выдает номер четверти плоскости, в которой находится эта плоскость

void Quarters(int x, int y)
{
    if (x == 0 || y == 0)
    {    
        Console.WriteLine("Либо x == 0, либо y == 0");
    }    
    else if(x > 0 && y > 0)
    {
        Console.WriteLine("Точка находится в первой четверти");
    }
    else if(x < 0 && y > 0)
    {
       Console.WriteLine("Точка находится во второй четверти"); 
    }
    else if(x < 0 && y < 0)
    {
       Console.WriteLine("Точка находится в третьей четверти"); 
    }
    else if(x > 0 && y < 0)
    {
       Console.WriteLine("Точка находится в четвертой четверти"); 
    }
}

Console.WriteLine("Напиши число: "); 
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши второе число: "); 
int num_2 = int.Parse(Console.ReadLine()!);

Quarters(num_1, num_2);
