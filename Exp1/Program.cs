/*Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/
int GetNumber()
{
    int result = 0;
    Console.WriteLine("Введите число");
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

void NumberM(int a, int b, int c, int d, int e)
{
    int count = 0;
    if (a > 0)
        count++;
    if (b > 0)
        count++;
    if (c > 0)
        count++;
    if (d > 0)
        count++;
    if (e > 0)
        count++;

    Console.WriteLine($"Вы ввели {count} числа больше 0");

    return;
}

int A = GetNumber();
int B = GetNumber();
int C = GetNumber();
int D = GetNumber();
int E = GetNumber();

NumberM(A, B, C, D, E);
