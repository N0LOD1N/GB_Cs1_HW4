Console.WriteLine("Задача 25--------------------");
void Cubify(int numA, int numB)
{
    double result = numA;
    for (int i = 1; i < Math.Abs(numB); i++)
    {
        result *= numA;
    }
    if (numB > 0) Console.WriteLine($" {numA}^{numB} = {result}");
    else if (numB < 0) Console.WriteLine($" {numA}^{numB} = {1 / result}");
}

Console.WriteLine("Введите два числа:");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());

Cubify(numA, numB);

Console.WriteLine("\nЗадача 27--------------------");

void Summify(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    Console.WriteLine($"Сумма всех цифр заданного числа равна {sum}.");
}

Console.Write("Введите число и узнайте сумму его цифр: ");
numA = Convert.ToInt32(Console.ReadLine());
Summify(numA);

Console.WriteLine("\nЗадача 29--------------------");

void RandomArray()
{
    int[] array = new int[new Random().Next(1, 100)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1) Console.Write(", ");
        else Console.WriteLine(".");
    }
}

Console.Write("Нажмите Enter, чтобы сгенерировать массив.");
Console.ReadLine();
RandomArray();