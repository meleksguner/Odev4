using System;

class Program
{
    static void Main(string[] args)
    {
        // Metodu test etmek için örnek bir çağrı
        double ortalama = OrtalamaHesapla(3.5, 4.0, 5.5, 6.0, 7.5);
        Console.WriteLine($"Girilen sayıların ortalaması: {ortalama}");
    }

    // params ile sınırsız sayıda double parametre alabilen metot
    static double OrtalamaHesapla(params double[] sayilar)
    {
        if (sayilar.Length == 0)
        {
            Console.WriteLine("Hiçbir sayı girilmedi!");
            return 0; // Veya bir hata fırlatabilirsiniz.
        }

        double toplam = 0;

        foreach (double sayi in sayilar)
        {
            toplam += sayi;
        }

        return toplam / sayilar.Length;
    }
}

