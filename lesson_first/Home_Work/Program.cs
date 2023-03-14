/* 
 
Задача 1. 
Напишите программу, которая на вход принимает два числа и выдаёт, какое большее, а какое меньшее. 
 
Console.WriteLine("Input your first number: "); 
int number_1 = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Input your seconde number: "); 
int number_2 = Convert.ToInt32(Console.ReadLine()); 
 
if (number_1 > number_2) 
 
{ 
    int maxresalt = number_1; 
    int minresalt = number_2; 
    Console.WriteLine($"From two numbers, the larger number is {number_1}, and the smaller number is {number_2}"); 
} 
else 
Console.WriteLine($"From two numbers, the larger number is {number_2}, and the smaller number is {number_1}"); 
 
Console.WriteLine($"Ну какая ж ты умница"); 
 
*/ 
 
/* 
 
Задача 2. 
Напишите программу, которая на вход принимает три числа, а на выход выдает максимальное из этих чисел. 
 
 
Console.WriteLine("Input your first number: "); 
int number_1 = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Input your seconde number: "); 
int number_2 = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Input your third number: "); 
int number_3 = Convert.ToInt32(Console.ReadLine()); 
 
if (number_1 > number_2 & number_1 > number_3) 
{ 
    int maxresalt = number_1; 
    Console.WriteLine($"From free numbers, the larger number is {number_1}"); 
} 
 
if(number_2 > number_1 & number_2 > number_3) 
{ 
    int maxresalt = number_2; 
    Console.WriteLine($"From free numbers, the larger number is {number_2}"); 
} 
 
else 
{ 
    Console.WriteLine($"From free numbers, the larger number is {number_3}"); 
} 
*/ 
 
/* 
Задача 3. 
Напишите программу, которая на вход принимает число и выдаёт является ли оно чётным (делится ли оно на два без остатка) 
 
 
Console.WriteLine("Input your number: "); 
int number = Convert.ToInt32(Console.ReadLine());  
 
if (number % 2 == 0)  
{ 
    Console.WriteLine("Your number is even"); 
} 
 
else  
{ 
    Console.WriteLine("Your number is odd"); 
} 

 

Задача 4. 
Напишите программу, которая на вход принимает число(number), а на выходе показывает все чётные числа от 1 до (number)
*/ 
 
Console.WriteLine("Input your number: "); 
int number = Convert.ToInt32(Console.ReadLine());  
 
int current_number = 2; 
 
while (current_number <= number) 
{ 
    
   Console.Write(current_number + " "); 
   current_number = current_number + 2; 
}

