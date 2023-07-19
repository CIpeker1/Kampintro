internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        int sayi1 = 10;
        int sayi2 = 30;
        sayi1 = sayi2;
        sayi2 = 65;
        Console.WriteLine(sayi2);
        //sayi1 ?? 30
        //kod cevabı 65 olarak buldu ama cevap 30 sebebi int olduğu için değer 10.sütunda sayi1 ve sayi2 eşitlendi ve sayi1 sayi2 ile bağlantısını kesti .


        int[] sayilar1 = new int[] { 10, 20, 30 };
        int[] sayilar2 = new int[] { 100, 200, 300 };
        sayilar1 = sayilar2;
        sayilar2[0] = 999;
        Console.WriteLine(sayilar1[0]);
        //cevap 999 çünkü sayilar1e new atadık ve 18.sütunda sayilar1 ve sayilar 2nin referanslarını esitledik yani sayilar1 in 0.elemanı sayilar2 nin 0.elemanı oldu
        //bu nedenle sayilar2 nin 0.elemanı 999 olduğundan cevap 999 :)))

        int sayi3 = 50;
        int sayi4 = 40;
        sayi3 = sayi4;
        sayi3 = 80;

       //sayi 4?  50
        Console.WriteLine(sayi3);


        int[] sayilar3 = new int[] { 888, 020, 558 };
        int[] sayilar4 = new int[] { 785, 153, 213 };
        sayilar3 = sayilar4;
        sayilar3[0] = 546;
        //sayilar4[0] = ?
        // cevap 546 cünkü sayilar3 ün referans numarsı sayilar4 ün referans numarasına eşitmiş sayilar3 üm referans numarası da 546:))
        Console.WriteLine(sayilar4[0]);
    }
}