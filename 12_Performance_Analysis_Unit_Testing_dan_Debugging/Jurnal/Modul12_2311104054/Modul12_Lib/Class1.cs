namespace Modul12_Lib
{
    public class Program
    {
        public static double CariNilaiPangkat(double angka, double pangkat)
        {
            return Math.Pow(angka, pangkat);
        }
    }

    public class Perhitungan
    {
        public static int Tambah(int a, int b) => a + b;
        public static int Kurang(int a, int b) => a - b;
        public static int Kali(int a, int b) => a * b;
    }
}
