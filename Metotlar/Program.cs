using Metotlar;
using System.Diagnostics;
using System.Security.Claims;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program 
{
    private static void Main(string[] args)
    {
        string urunAdi = "Elma";
        double fiyati = 15;
        string aciklaması1 = "Amasya Elması";

        string urunAdi2 = "Çilek";
        double fiyati2 = 44;
        string aciklamasi2 = "Çilek gibi Çilek";

        string[] meyveler = new string[] { };

        Urun urun1 = new Urun();
        urun1.urunAdi = "Elma";
        urun1.fiyati = 15;
        urun1.aciklamasi = "Amasya Elması";

        Urun urun2 = new Urun();
        urun2.urunAdi = "Çilek";
        urun2.fiyati = 44;
        urun2.aciklamasi = "Çilek gibi Çilek";

        Urun[] urunler = new Urun[] {urun1, urun2 };

        
        //type safe -- tip güvenliği 
        
        foreach (Urun urun in urunler)
        {
            Console.WriteLine(urun.urunAdi);
            Console.WriteLine(urun.fiyati);
            Console.WriteLine(urun.urunAdi);
            Console.WriteLine("-----------------");
        }

        Console.WriteLine("----------Metotlar-------------");

        SepetManager sepetManager = new SepetManager();

        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);



        sepetManager.Ekle2("Armut","Yeşil Armut", 17, 10);
        sepetManager.Ekle2("Elma","Yeşil Elma", 27, 9 );
        sepetManager.Ekle2("Karpuz","Yeşil Karpuz", 37, 2);



    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}