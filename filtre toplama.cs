using System;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = { 3, 7, 1, 9, 12, 5 };
        int filtreDegeri = 6;

        int toplam = ToplaVeFiltrele(dizi, filtreDegeri);
        Console.WriteLine($"Filtre değerinden büyük olan elemanların toplamı: {toplam}");
    }

    static int ToplaVeFiltrele(int[] dizi, int filtreDegeri)
    {
        int toplam = 0;

        foreach (int eleman in dizi)
        {
            if (eleman > filtreDegeri)
            {
                toplam += eleman;
            }
        }

        return toplam;
    }
}

