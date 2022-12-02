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

/*Задача 50 Семинар 7
Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [5,5];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}


Задача 50 Семинар 7
Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
*/

/*Задача 54 Семинар 8
Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Массив до изменения");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < numbers.GetLength(1) - 1; z++)
        {
            if (numbers[i, z] < numbers[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
            {
                int temp = 0;
                temp = numbers[i, z];
                numbers[i, z] = numbers[i, z + 1];
                numbers[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
*/

/*Задача 56 Семинар 8
Console.WriteLine("введите размер квадратного массива");
int massVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[massVol, massVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int minsum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}




int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5); //Для увеличения размера чисел в матрицах поменять число 5 на большее
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int size = InputInt("размерность матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillArrayRandomNumbers(matrixA);
FillArrayRandomNumbers(matrixB);
int[,] matrixC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
PrintArray(matrixC);

Семинар 9 Задача 64
int n = InputInt("Введите положительное число");
int m = 1;
if (n < 1)
{
    Console.WriteLine("Ввели не положительное число");
}
Console.WriteLine(NaturalNumber(n, m));

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
Семинар 9 Задача 66
int m = InputInt("Введите M:");
int n = InputInt("Введите N:");
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}
Семинар 9 задача 68
Console.WriteLine("Введите два положительных числа: M и N.");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}
*/