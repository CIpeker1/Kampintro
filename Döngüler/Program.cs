internal class Program
{
    private static void Main(string[] args)
    {
        string kurs1 = "Yazılım Geliştirme Kursu";
        string kurs2 = "Yazılıma giriş kursu";
        string kurs3 = "Java";
        Console.WriteLine(kurs1);
        Console.WriteLine(kurs2);
        Console.WriteLine(kurs3);

        //gerçek hayatta tek tek yazamayacapımız için biri dizinin içine almamız gerekiyor        
        //array = dizi 

        string[] kurslar = new string[] { "Yazlılınm Geliştirme Kursu", "Yazılıma Giriş", "Java","phyton","C++" };

        //dinamik bir site yapmadk için i<3 fonksiyonuna i<kurslar.lenght; yazarız
        for (int i = 0; i<kurslar.Length; i++)
        {
            Console.WriteLine(kurslar[i]);
        }
        Console.WriteLine("for bitti");


        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs);
        }



        Console.WriteLine("sayfa sonu - footer ");
    }
}