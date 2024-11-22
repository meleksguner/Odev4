using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Üçgenin taban uzunluğunu giriniz: ");
        double taban= Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Üçgenin yüksekliğini giriniz: ");
        double yukseklik = Convert.ToDouble(Console.ReadLine());

        double alan = ucgenalan(taban, yukseklik);
        Console.WriteLine($"üçgenin alanı: {alan}" );
        

    }

    static double ucgenalan(double taban, double yukseklik)
    {
        return (taban * yukseklik) / 2;
    }
    
}
