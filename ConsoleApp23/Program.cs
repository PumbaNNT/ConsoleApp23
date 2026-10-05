using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("It's easy to win forgiveness for being wrong;");
        Console.WriteLine("being right is what gets you into real trouble.");
        Console.WriteLine("Bjarne Stroustrup");
    }
}





using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть 5 чисел: ");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        int sum = a + b + c + d + e;
        int max = Math.Max(a, Math.Max(b, Math.Max(c, Math.Max(d, e))));
        int min = Math.Min(a, Math.Min(b, Math.Min(c, Math.Min(d, e))));
        int product = a * b * c * d * e;

        Console.WriteLine("Сума: " + sum);
        Console.WriteLine("Максимум: " + max);
        Console.WriteLine("Мінімум: " + min);
        Console.WriteLine("Добуток: " + product);
    }
}




using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть шестизначне число: ");
        int number = int.Parse(Console.ReadLine());

        int a = number / 100000;
        int b = number / 10000 % 10;
        int c = number / 1000 % 10;
        int d = number / 100 % 10;
        int e = number / 10 % 10;
        int f = number % 10;

        int result = f * 100000 + e * 10000 + d * 1000 + c * 100 + b * 10 + a;

        Console.WriteLine("Результат: " + result);
    }
}




using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть початок діапазону: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Введіть кінець діапазону: ");
        int end = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;

        while (a <= end)
        {
            if (a >= start)
                Console.Write(a + " ");

            int next = a + b;
            a = b;
            b = next;
        }
    }
}




using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Введіть B: ");
        int B = int.Parse(Console.ReadLine());

        for (int i = A; i <= B; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}




using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть довжину лінії: ");
        int length = int.Parse(Console.ReadLine());

        Console.Write("Введіть символ: ");
        char symbol = char.Parse(Console.ReadLine());

        Console.Write("Введіть напрямок (горизонтальна/вертикальна): ");
        string direction = Console.ReadLine();

        if (direction == "горизонтальна")
        {
            for (int i = 0; i < length; i++)
                Console.Write(symbol);
        }
        else if (direction == "вертикальна")
        {
            for (int i = 0; i < length; i++)
                Console.WriteLine(symbol);
        }
    }
}