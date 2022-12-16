// Задача 64: 
// Задайте значение N. Напишите метод, который выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Задача 64");
Console.Write("Введите число N: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedN || n <= 0)
{
    Console.WriteLine("Ошибка, не правильно введено число!");
    return;
}

PrintNumbersToN(n);

void PrintNumbersToN(int number)
{
    if (number < 1) return;

    Console.Write($" {number}, ");
    PrintNumbersToN(number - 1);
}

Console.WriteLine();
Console.WriteLine("Для продолжения нажмите любую кнопку");
Console.ReadKey();


// Задача 66: 
// Задайте значения M и N. Напишите метод, который найдёт сумму натуральных элементов в промежутке от M до N. Через рекурсию!
Console.Clear();
Console.WriteLine("Задача 66");

Console.Write("Введите 1 число: ");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
Console.Write("Введите 2 число: ");
bool isParsedB = int.TryParse(Console.ReadLine(), out int b);

if (!isParsedA || !isParsedB || a == b)
{
    Console.WriteLine("Ошибка, не правильно введены числа для данной задачи!");
    return;
}

if (b > a) Console.WriteLine($"Результат = {SumBetweenNumbers(a, b)}");
else Console.WriteLine($"Результат = {SumBetweenNumbers(b, a)}");


int SumBetweenNumbers(int number1, int number2)
{
    if (number1 > number2) return 0;
    return number1 + SumBetweenNumbers(++number1, number2);
}


Console.WriteLine();
Console.WriteLine("Для продолжения нажмите любую кнопку");
Console.ReadKey();

// Задача 68
// Напишите метод вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();
Console.WriteLine("Задача 68");

Console.Write("Введите первое число (M): ");
bool isParsedX = int.TryParse(Console.ReadLine(), out int x);
Console.Write("Введите второе число (N): ");
bool isParsedY = int.TryParse(Console.ReadLine(), out int y);

if (!isParsedX || !isParsedY)
{
    Console.WriteLine("Ошибка, не правильно введены числа для данной задачи!");
    return;
}

Console.WriteLine($"Результат = {AckermannFunc(x, y)}");

int AckermannFunc(int m, int n)
{
    if (m == 0) return ++n;

    if (m != 0 && n == 0) return AckermannFunc(m - 1, 1);

    if (m > 0 && n > 0) return AckermannFunc(m - 1, AckermannFunc(m, n - 1));

    return AckermannFunc(m, n);
}
