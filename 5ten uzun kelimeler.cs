//Metod
//Mesaj Göster
public void MesajGoster()
{
    Console.WriteLine("Merhaba");

}
public void MesajGoster(string mesajiniz)
{
    Console.WriteLine("" + mesajiniz);

}

public void AcilArama()
{
    Console.WriteLine("Acil arama 112 yapılıyor");

}


       }

       static void Main(string[] args)
{
    //Console.WriteLine("Hello, World!");

    //CepTelefonu class'ından NESNE türetme (oluşturma)
    //Class içindeki özellik ve metodlara erişim yöntemi - 1

    CepTelefonu telefon = new CepTelefonu();

    //NEW ANAHTAR KELİMESİ ile CepTelefonu class'ından telefon adında bir nesne türetildi.
    //Türetilen nesne sayesinde (telefon) sınıf içinde yer alan özellik ve metodlara erişim sağlanabilecektir.

    //MesajGoster metoduna erişebildik.
    telefon.MesajGoster();

    telefon.Marka = "Samsung";
    telefon.GarantiYil = 3;
    telefon.Model = "12A";
    telefon.PilOmru = "3 Yıl";

    Console.ReadKey();


    //Araba class
    //Özellikler
    //Metodlar




}
   }
}