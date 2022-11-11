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
    int[] matr = new int[8];
    for (int i = 0; i < kol; i++) {
        matr[i] = new Random().Next(11,35);
    }
    return matr;
}
void Print (int[] matr) {
    Console.WriteLine (string.Join (" ",matr));
}
int[] matr = new int[8];
matr = CreateMas ();
Print (matr);
*/

/* Семинар 5 Задача 34 Массив из положительных трехзначных чисел, и показать сколько четных
int[] CreateMas(){
    int kol = 8;
    int[] matr = new int[8];
    for (int i = 0; i < kol; i++) {
        matr[i] = new Random().Next(100,999);
    }
    return matr;
}
void Print (int[] matr) {
    Console.WriteLine (string.Join (" ",matr));
}
int[] matr = new int[8];
matr = CreateMas ();
Print (matr);
int count = 0;
    for (int i = 0; i < matr.Length; i++)
    if (matr[i] % 2 == 0)
count++;
Console.WriteLine($"всего {matr.Length} чисел, {count} из них чётные");
*/

/*Семинар 5 Задача 36 Массив из положительных чисел, и показать сумму на нечетных позициях
int[] CreateMas(){
    int kol = 5;
    int[] matr = new int[5];
    for (int i = 0; i < kol; i++) {
        matr[i] = new Random().Next(1,10);
    }
    return matr;
}
void Print (int[] matr) {
    Console.WriteLine (string.Join (" ",matr));
}
int[] matr = new int[5];
matr = CreateMas ();
Print (matr);
int sum = 0;
    for (int i = 0; i < matr.Length; i+=2)
    sum = sum + matr[i];

Console.WriteLine($"{sum} - сумма нечетных элементов");
*/

/*Семинар 5 Задача 38 Найти разницу между максимальным и минимальным значением
int[] CreateMas(){
    int kol = 5;
    int[] matr = new int[5];
    for (int i = 0; i < kol; i++) {
        matr[i] = new Random().Next(1,10);
    }
    return matr;
}
void Print (int[] matr) {
    Console.WriteLine (string.Join (" ",matr));
}
int[] matr = new int[5];
matr = CreateMas ();
Print (matr);
int max = 0;
int min = 1;
for (int i = 0; i < matr.Length; i++)
{
    if (matr[i] > max)
        {
            max = matr[i];
        }
    if (matr[i] < min)
        {
            min = matr[i];
        }
}
Console.WriteLine($" Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
*/

/*
Задача 41 семинар 6
Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($" Чисел больше 0  - {sum}");

int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    Console.Write("* ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write(" *");
}

Задача 43 семинар 6
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
*/

/*Console.Write("Введите номер строки: ");
int str = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите номер столбца: ");
int stlb = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 5; 
int m = 7; 
Random random = new Random();
int[,] matr = new int[n, m];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
{
    matr[i, j] = random.Next(10, 99);
Console.Write("{0} ", matr[i, j]);
}
Console.WriteLine();
}
    if (str < 0 | str > matr.GetLength(0) - 1 | stlb
 < 0 | stlb
 > matr.GetLength(1) - 1)
{
Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", matr[str, stlb
]);
}
Console.ReadLine();
*/


Сonsole.Write("Введите номер строки: ");
int str = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите номер столбца: ");
int stlb = Convert.ToInt32(Console.ReadLine()) - 1;
void PrintArray(int[,] matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)
 {
 for (int j = 0; j < matr.GetLength(1); j++)
 {
 Console.Write($"{matr[i, j]} ");
 }
 Console.WriteLine();
 }
}
void FillArray(int[,] matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)
 {
 for (int j = 0; j < matr.GetLength(1); j++)
 {
 matr[i,j] = new Random().Next(1,10);
 }
 }
}
int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);

if (str < 0 | str > matrix.GetLength(0) - 1 | stlb < 0 | stlb> matrix.GetLength(1) - 1)
{
Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", matrix[str, stlb]);
}
