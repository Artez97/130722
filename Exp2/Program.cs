/*Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

int GetNumber()
{
    int result = 0;
    Console.WriteLine();
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не корректное число. Введите корректное число ");
        }
    }

    return result;
}

void Funct1(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    if (k1 == k2)
    {
        Console.WriteLine($"  k1 и k2 равны => прямые параллельны.");

    }
    else
    {
        x = ((b2 - b1) / (k1 - k2));
        y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
    }
    Console.WriteLine($"x = (({b2} - {b1}) / ({k1} - {k2}))");
    Console.WriteLine($"y = {k1} * (({b2} - {b1}) / ({k1} - {k2})) + {b1})");
    Console.WriteLine($"({x}, {y})");
    return;
}

Console.Write("Введите элемент b1: ");
double A = GetNumber();
Console.Write("Введите элемент k1: ");
double B = GetNumber();
Console.Write("Введите элемент b2: ");
double C = GetNumber();
Console.Write("Введите элемент k2: ");
double D = GetNumber();

Funct1(A, B, C, D);
