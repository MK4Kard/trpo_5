// Дано число n.Для каждой цифры d прибавьте к числу d! (факториал цифры). Повторяйте, пока сумма не станет делиться на n или не превысит его в 10 раз.
// d = 125
// 125 + 1! + 2! + 5! = 125 + 1 + 2 + 120 = 248

Console.Write("Введите число n: ");
if (!int.TryParse(Console.ReadLine(), out int n))
{
    Console.WriteLine("Неверный тип данных");
    return 1;
}

Console.Write("Введите число d: ");
if (!int.TryParse(Console.ReadLine(), out int d))
{
    Console.WriteLine("Неверный тип данных");
    return 1;
}

int x = d; // сумма
int f = 1;

while ((x % n) != 0 && n * 10 >= x)
{
    while (d > 0)
    {
        for (int i = 1; i <= d % 10; i++) // факториал -> d % 10
        {
            f *= i;
        }
        x += f;
        d /= 10;
        f = 1;
    }

    d = x;
}

Console.WriteLine($"Сумма равна: {x}");
Console.ReadKey();

return 0;