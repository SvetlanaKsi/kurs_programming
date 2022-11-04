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

/* Задача 6. Четное или нечетное число
Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
if (number1%2 == 0)
Console.WriteLine("Число является четным");
else
Console.WriteLine("Число является нечетным");
*/

/*Задача 8 На вход принимает число N, на выходе показывает все четные числа от 1 до N 
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 2;
while (i<=N)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i + ", ");
    }
i++;
}  
*/

/*Семинар 2
Задача 10 На входе 3-х значное число и на выходе показывает вторую цифру этого числа.
int num = new Random().Next(100,999);
Console.WriteLine(num);
int result = (num/10)%10;
Console.WriteLine (result);
*/




/*Console.WriteLine ("Введите число: ");
int num = int.Parse(Console.ReadLine());
string str = num.ToString();
int[] b = new int[str.Length];
for( int i=0; i< str.Length; i++)
    {
     b[i] = int.Parse(str[i].ToString());
    } 
if (i=2)
     Console.WriteLine ("Третьей цифры нет"); 
else              
Console.WriteLine ($"Третья цифра заданого числа: {b[2]}");
*/

/* Семинар 4. Задача 25. 
Console.WriteLine ("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите число B: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine ($"{A} в степени {B} = " + Math.Pow (A,B));
*/

/* Семинар 4. Задача 27. 
Console.WriteLine("Введите число");
int i = int.Parse(Console.ReadLine());
int sum = 0;
while (i > 0)
{
    int num = i % 10;
    i = i / 10;
    sum = sum + num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);
*/


/* Семинар 4. Задача 29.
int[] CreateMas(){
    int kol = 8;
    int[] arr = new int[8];
    for (int i = 0; i < kol; i++) {
        arr[i] = new Random().Next(11,35);
    }
    return arr;
}
void Print (int[] arr) {
    Console.WriteLine (string.Join (" ",arr));
}
int[] arr = new int[8];
arr = CreateMas ();
Print (arr);
*/

/* Семинар 5 Задача 34 Массив из положительных трехзначных чисел, и показать сколько четных
int[] CreateMas(){
    int kol = 8;
    int[] arr = new int[8];
    for (int i = 0; i < kol; i++) {
        arr[i] = new Random().Next(100,999);
    }
    return arr;
}
void Print (int[] arr) {
    Console.WriteLine (string.Join (" ",arr));
}
int[] arr = new int[8];
arr = CreateMas ();
Print (arr);
int count = 0;
    for (int i = 0; i < arr.Length; i++)
    if (arr[i] % 2 == 0)
count++;
Console.WriteLine($"всего {arr.Length} чисел, {count} из них чётные");
*/

/*Семинар 5 Задача 36 Массив из положительных чисел, и показать сумму на нечетных позициях
int[] CreateMas(){
    int kol = 5;
    int[] arr = new int[5];
    for (int i = 0; i < kol; i++) {
        arr[i] = new Random().Next(1,10);
    }
    return arr;
}
void Print (int[] arr) {
    Console.WriteLine (string.Join (" ",arr));
}
int[] arr = new int[5];
arr = CreateMas ();
Print (arr);
int sum = 0;
    for (int i = 0; i < arr.Length; i+=2)
    sum = sum + arr[i];

Console.WriteLine($"{sum} - сумма нечетных элементов");
*/

/*Семинар 5 Задача 38 Найти разницу между максимальным и минимальным значением
int[] CreateMas(){
    int kol = 5;
    int[] arr = new int[5];
    for (int i = 0; i < kol; i++) {
        arr[i] = new Random().Next(1,10);
    }
    return arr;
}
void Print (int[] arr) {
    Console.WriteLine (string.Join (" ",arr));
}
int[] arr = new int[5];
arr = CreateMas ();
Print (arr);
int max = 0;
int min = 1;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
        {
            max = arr[i];
        }
    if (arr[i] < min)
        {
            min = arr[i];
        }
}
Console.WriteLine($" Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
/*