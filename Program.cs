/*Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1>number2)
    Console.WriteLine($"Первое число {number1} большее, а второе число {number2} меньшее");
    else
    Console.WriteLine($"Второе число {number2} большее, а первое число {number1} меньшее");
*/  


/* Задача 4. Найти максимальное из 3 чисел
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());
int max = number1;
if (number2>max) 
    max = number2;
if (number3>max) 
    max = number3;
Console.WriteLine("Масксимальное число " + max);
*/

Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
if (number1%2 == 0)
Console.WriteLine("Число является четным");
else
Console.WriteLine("Число является нечетным");