using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(CalculateYearsAfter18(64)); // Verilen yaş: 64
        Console.WriteLine(CalculateYearsAfter18(25)); // Verilen yaş: 25
        Console.WriteLine(CalculateYearsAfter18(18)); // Verilen yaş: 18
        Console.WriteLine(CalculateYearsAfter18(16)); // Verilen yaş: 16
    }

    static int CalculateYearsAfter18(int age = 18)
    {
        if (age < 18)
        {
            return 0; // 18 yaşından küçükse 0 döndür.
        }

        return age - 18; // 18 yaşından fazla olan yılları hesapla.
    }
}

