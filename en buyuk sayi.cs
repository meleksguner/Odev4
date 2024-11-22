using System;

class Program
{
    static void Main()
    {
        // Örnek bir dizi
        int[] numbers = { 12, 45, 78, 23, 56, 89, 10 };

        // Metodu çağır ve sonucu al
        int maxValue = FindMaxValue(numbers);

        // Sonucu ekrana yazdır
        Console.WriteLine("Dizideki en büyük değer: " + maxValue);
    }

    // Dizideki en büyük değeri bulan metot
    static int FindMaxValue(int[] array)
    {
        int max = int.MinValue; // Başlangıç değeri (minimum int değeri)

        foreach (int num in array)
        {
            if (num > max)
            {
                max = num; // Daha büyük bir değer bulundu
            }
        }

        return max; // En büyük değeri döndür
    }
}

