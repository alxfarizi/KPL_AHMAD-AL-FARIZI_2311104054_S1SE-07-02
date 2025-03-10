using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Masukkan nama Anda: ");
        string nama = Console.ReadLine();
        Console.WriteLine($"Selamat datang, {nama}!");

        int[] array = new int[7];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
            if (i % 2 == 0 && i % 3 == 0)
            {
                Console.WriteLine($"{array[i]} #$#$");
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine($"{array[i]} ##");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine($"{array[i]} $$");
            }
            else
            {
                Console.WriteLine($"{array[i]}");
            }
        }

        Console.Write("Masukkan angka (1-10000): ");
        string nilaiString = Console.ReadLine();
        int nilaiInt = Convert.ToInt32(nilaiString);

        if (ApakahBilanganPrima(nilaiInt))
        {
            Console.WriteLine($"Angka {nilaiInt} merupakan bilangan prima.");
        }
        else
        {
            Console.WriteLine($"Angka {nilaiInt} bukan merupakan bilangan prima.");
        }
    }

    static bool ApakahBilanganPrima(int angka)
    {
        if (angka <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(angka); i++)
        {
            if (angka % i == 0) return false;
        }
        return true;
    }
}
