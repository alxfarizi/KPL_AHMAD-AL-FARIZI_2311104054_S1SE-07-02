using System;
using AljabarLibraries;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double[] persamaanKuadrat = { 1, -3, -10 };
                double[] akar = Aljabar.AkarPersamaanKuadrat(persamaanKuadrat);
                Console.WriteLine("Akar-akar persamaan kuadrat: {0}, {1}", akar[0], akar[1]);

                double[] persamaanLinear = { 2, -3 };
                double[] hasilKuadrat = Aljabar.HasilKuadrat(persamaanLinear);
                Console.WriteLine("Hasil kuadrat persamaan: {0}, {1}, {2}",
                                  hasilKuadrat[0], hasilKuadrat[1], hasilKuadrat[2]);

            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi kesalahan: " + e.Message);
            }
        }
    }
}
