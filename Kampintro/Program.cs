internal class Program
{
    private static void Main(string[] args)
    {
        string kategoriEtiketi = "Kategoriler!!!!!";
        int ogrenciSayisi = 30000;
        double faizOrani = 1.75;
        bool sistemeGirisYapmışMi = false;
        double dolarDun = 7.44;
        double dolarBugun = 7.44;

        if (dolarDun>dolarBugun)
        {
            Console.WriteLine("Azalış Butonu");
        }
        else if (dolarDun<dolarBugun)
            {
            Console.WriteLine("Artış Butonu");
        }
        else
        {
            Console.WriteLine("Değinme Olmadı Butonu");
        }

        if (sistemeGirisYapmışMi == true)
        {
            Console.WriteLine("Kullanıcı Ayarları");
        }
        else
        {
            Console.WriteLine("Giriş Yap");
        }



        Console.WriteLine(kategoriEtiketi);
        Console.WriteLine(kategoriEtiketi);
        Console.WriteLine(kategoriEtiketi);
        Console.WriteLine(kategoriEtiketi);
        Console.WriteLine(kategoriEtiketi);
    }
}