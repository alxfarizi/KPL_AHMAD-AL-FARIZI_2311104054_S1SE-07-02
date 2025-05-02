using System;

namespace AljabarLibraries
{
    public class Aljabar
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            if (persamaan.Length != 3)
                throw new ArgumentException("Persamaan harus memiliki 3 elemen: a, b, dan c.");

            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double diskriminan = (b * b) - (4 * a * c);

            if (diskriminan < 0)
                throw new ArgumentException("Persamaan tidak memiliki akar real.");

            double akar1 = (-b + Math.Sqrt(diskriminan)) / (2 * a);
            double akar2 = (-b - Math.Sqrt(diskriminan)) / (2 * a);

            return new double[] { akar1, akar2 };
        }

        public static double[] HasilKuadrat(double[] persamaan)
        {
            if (persamaan.Length != 2)
                throw new ArgumentException("Persamaan harus memiliki 2 elemen: a dan b.");

            double a = persamaan[0];
            double b = persamaan[1];

            double aKuadrat = a * a;
            double duaAb = 2 * a * b;
            double bKuadrat = b * b;

            return new double[] { aKuadrat, duaAb, bKuadrat };
        }
    }
}
