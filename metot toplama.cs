using System;

class Program
{
    // İlk metot: İki int sayıyı toplar.
    static int CalculateSum(int a, int b)
    {
        return a + b;
    }

    // İkinci metot: İki double sayıyı toplar.
    static double CalculateSum(double a, double b)
    {
        return a + b;
    }

    // Üçüncü metot: Üç int sayıyı toplar.
    static int CalculateSum(int a, int b, int c)
    {
        return a + b + c;
    }

    static void Main(string[] args)
    {
        // İlk metot çağrısı
        int sum1 = CalculateSum(5, 10);
        Console.WriteLine("İki int'in toplamı: " + sum1);

        // İkinci metot çağrısı
        double sum2 = CalculateSum(5.5, 10.3);
        Console.WriteLine("İki double'ın toplamı: " + sum2);

        // Üçüncü metot çağrısı
        int sum3 = CalculateSum(1, 2, 3);
        Console.WriteLine("Üç int'in toplamı: " + sum3);
    }
}

