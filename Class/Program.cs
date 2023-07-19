internal class Program
{
    private static void Main(string[] args)
    {
        //string[] kurslar = new string[] { };
        
        string adi = "Can Ipeker";
        int yas = 36;

        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "Java";
        kurs1.Eğitmen = "Engin Demirog";
        kurs1.IzlenmeOrani = 4;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "python";
        kurs2.Eğitmen = "barıs Demirog";
        kurs2.IzlenmeOrani = 7;


        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "c++";
        kurs3.Eğitmen = "Engin asd";
        kurs3.IzlenmeOrani = 5;


        Kurs kurs4 = new Kurs();
        kurs4.KursAdi = "ask";
        kurs4.Eğitmen = "Ali Cabbar";
        kurs4.IzlenmeOrani = 7;
        //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Eğitmen);
        //Console.WriteLine(kurs2.KursAdi + " : " + kurs2.Eğitmen);

        Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4};
        
        foreach (var kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdi + " : " + kurs.Eğitmen); 
        }







    }
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Eğitmen { get; set; }
    public int IzlenmeOrani { get; set; }

}
