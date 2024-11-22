using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Fibonacci dizisinde kaçıncı elemanı hesaplamak istiyorsunuz? ");
        int n = int.Parse(Console.ReadLine());

        int result = Fibonacci(n);
        Console.WriteLine($"{n}. Fibonacci sayısı: {result}");
    }

    static int Fibonacci(int n)
    {
        if (n <= 0)
            throw new ArgumentException("n pozitif bir sayı olmalıdır.");
        if (n == 1 || n == 2)
            return 1; // İlk iki Fibonacci sayısı 1'dir.
        return Fibonacci(n - 1) + Fibonacci(n - 2); // Özyinelemeli çağrılar.
    }
}

