using System;

// Kelas generik untuk menyimpan dan menampilkan data
public class GenericData<T>
{
    private T _data;

    // Konstruktor untuk menyimpan data
    public GenericData(T data)
    {
        _data = data;
    }

    // Method untuk mencetak data yang tersimpan
    public void DisplayData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {_data}");
    }
}

// Kelas utama Program
class Program
{
    static void Main()
    {
        // Membuat objek GenericData dengan NIM dan menampilkan data
        GenericData<string> studentData = new GenericData<string>("2211104005");
        studentData.DisplayData();
    }
}
