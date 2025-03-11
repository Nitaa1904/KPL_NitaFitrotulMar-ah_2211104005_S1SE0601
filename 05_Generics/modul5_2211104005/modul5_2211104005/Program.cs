public class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T a, T b, T c) where T : struct
    {
        dynamic x = a;
        dynamic y = b;
        dynamic z = c;
        return x + y + z;
    }
}

class Program
{
    static void Main()
    {
        double hasil = Penjumlahan.JumlahTigaAngka(22.0, 11.0, 10.0);
        Console.WriteLine($"Hasil penjumlahan: {hasil}");
    }
}