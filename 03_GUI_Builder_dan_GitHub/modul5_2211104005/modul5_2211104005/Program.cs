using System;

class Penjumlahan
{
    // Method generic untuk menjumlahkan tiga angka
    public static T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic a = angka1;
        dynamic b = angka2;
        dynamic c = angka3;

        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        // Input angka berdasarkan dua digit NIM: 22, 11, 10
        int hasil = Penjumlahan.JumlahTigaAngka(22, 11, 10);

        // Menampilkan hasil
        Console.WriteLine($"Hasil Penjumlahan: {hasil}");
    }
}