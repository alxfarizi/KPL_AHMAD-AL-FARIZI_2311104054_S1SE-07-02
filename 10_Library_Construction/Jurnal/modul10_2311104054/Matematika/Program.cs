using System;
using MatematikaLibraries;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("================ Jurnal Modul 10 ======================");
        Console.WriteLine("FPB(60, 45)             : " + Matematika.FPB(60, 45));

        Console.WriteLine("KPK(12, 8)              : " + Matematika.KPK(12, 8));

        int[] persamaanTurunan = { 1, 4, -12, 9 }; 
        Console.WriteLine("Turunan({1, 4, -12, 9}) : " + Matematika.Turunan(persamaanTurunan));

        int[] persamaanIntegral = { 4, 6, -12, 9 }; 
        Console.WriteLine("Integral({4, 6, -12, 9}): " + Matematika.Integral(persamaanIntegral));
        Console.WriteLine("=======================================================");
    }
}
