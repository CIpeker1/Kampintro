using Matematik;

internal class Program
{
    private static void Main(string[] args)
    {
        DortIslem dortIslem = new DortIslem();
        dortIslem.Topla(5, 3);

        dortIslem.Topla(7, 9);

        dortIslem.Topla(5123, 16);
    }
}