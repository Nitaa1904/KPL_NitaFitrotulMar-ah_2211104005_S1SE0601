using System;

class HaloGeneric<T>
{
    public void SapaUser(T nama)
    {
        Console.WriteLine($"Halo user {nama}");
    }
}
class Program
{
    static void Main()
    {
        HaloGeneric<string> sapa = new HaloGeneric<string>();
        sapa.SapaUser("Nita");  // Menggunakan nama panggilan
    }
}
