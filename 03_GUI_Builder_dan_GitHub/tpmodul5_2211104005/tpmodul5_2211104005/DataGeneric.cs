using System;

public class DataGeneric<T>
{
    private T data; // Properti generic

    // Konstruktor untuk menyimpan data
    public DataGeneric(T data)
    {
        this.data = data;
    }

    // Method untuk mencetak data yang tersimpan
    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}
