using System;

namespace modul13_2311104054
{
    class Program
    {
        static void Main(string[] args)
        {
            PusatDataSingleton data1 = PusatDataSingleton.GetDataSingleton();
            PusatDataSingleton data2 = PusatDataSingleton.GetDataSingleton();

            data1.AddSebuahData("Anggota 1 - Farhan");
            data1.AddSebuahData("Anggota 2 - Shafiq");
            data1.AddSebuahData("Asisten - Al-Farizi");

            Console.WriteLine("Data dari data2:");
            data2.PrintSemuaData();

            data2.HapusSebuahData(2);

            Console.WriteLine("\nData dari data1 setelah penghapusan:");
            data1.PrintSemuaData();

            Console.WriteLine($"\nJumlah data di data1: {data1.GetSemuaData().Count}");
            Console.WriteLine($"Jumlah data di data2: {data2.GetSemuaData().Count}");
        }
    }
}
