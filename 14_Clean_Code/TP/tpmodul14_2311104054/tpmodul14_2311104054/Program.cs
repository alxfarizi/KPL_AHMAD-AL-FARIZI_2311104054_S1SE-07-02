using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Implementasi dari TP Modul 2");
        Console.WriteLine("");
        // Input karakter dari pengguna
        Console.Write("Masukkan satu huruf: ");
        char inputChar = Console.ReadKey().KeyChar;
        Console.WriteLine();
        Console.WriteLine("");

        // Mengecek apakah karakter merupakan huruf vokal
        if ("AIUEO".Contains(inputChar))
        {
            Console.WriteLine($"Huruf {inputChar} merupakan huruf vokal");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine($"Huruf {inputChar} merupakan huruf konsonan");
            Console.WriteLine("");
        }

        // Array bilangan genap
        int[] evenNumbers = { 2, 4, 6, 8, 10 };

        // Menampilkan setiap elemen dalam array
        for (int index = 0; index < evenNumbers.Length; index++)
        {
            Console.WriteLine($"Angka genap {index + 1}: {evenNumbers[index]}");
        }
    }
}
