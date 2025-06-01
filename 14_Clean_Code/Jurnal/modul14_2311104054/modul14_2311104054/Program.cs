using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Implementasi dari Modul Jurnal 2");
        Console.WriteLine("");
        Console.Write("Masukkan nama Anda: ");
        string nama = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Selamat datang, {nama}!");
        Console.WriteLine();

        int[] angkaArray = new int[7];

        for (int i = 0; i < angkaArray.Length; i++)
        {
            angkaArray[i] = i;

            if (i % 2 == 0 && i % 3 == 0)
            {
                Console.WriteLine($"{angkaArray[i]} #$#$");
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine($"{angkaArray[i]} ##");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine($"{angkaArray[i]} $$");
            }
            else
            {
                Console.WriteLine($"{angkaArray[i]}");
            }
        }

        Console.WriteLine();
        Console.Write("Masukkan angka (1-10000): ");
       
        string inputNilai = Console.ReadLine();
        int nilai = Convert.ToInt32(inputNilai);

        Console.WriteLine();

        if (ApakahBilanganPrima(nilai))
        {
            Console.WriteLine($"Angka {nilai} merupakan bilangan prima.");
        }
        else
        {
            Console.WriteLine($"Angka {nilai} bukan merupakan bilangan prima.");
        }
    }

    /// <summary>
    /// Mengecek apakah sebuah bilangan adalah bilangan prima.
    /// </summary>
    /// <param name="angka">Bilangan yang akan dicek.</param>
    /// <returns>true jika bilangan prima, false jika bukan.</returns>
    static bool ApakahBilanganPrima(int angka)
    {
        if (angka <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(angka); i++)
        {
            if (angka % i == 0)
                return false;
        }

        return true;
    }
}
