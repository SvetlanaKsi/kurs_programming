// See https://aka.ms/new-console-template for more information
Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Квадрат {number} равен {number*number}");
Console.WriteLine("Ваше имя " + name);