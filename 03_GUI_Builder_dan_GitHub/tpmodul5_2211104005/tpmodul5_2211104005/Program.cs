using System;

class Program
{
    static void Main()
    {
        // Memanggil method SapaUser dari class HaloGeneric
        HaloGeneric<string> sapa = new HaloGeneric<string>();
        sapa.SapaUser("Nita");

        // Menggunakan Generic Class DataGeneric
        DataGeneric<string> data = new DataGeneric<string>("2211104005");
        data.PrintData();
    }
}
