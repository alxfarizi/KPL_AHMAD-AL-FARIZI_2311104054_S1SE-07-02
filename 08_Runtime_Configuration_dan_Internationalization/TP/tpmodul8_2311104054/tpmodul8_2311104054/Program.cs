using tpmodul8_2311104054;

class Program
{
    public static void Main()
    {
        CovidConfig config = new CovidConfig();

        Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {config.SatuanSuhu}");
        double suhu = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
        int hariDeman = Convert.ToInt32(Console.ReadLine());

        bool suhuValid = false;
        if (config.SatuanSuhu == "celcius")
        {
            suhuValid = suhu >= 36.5 && suhu <= 37.5;
        }
        else if (config.SatuanSuhu == "fahrenheit")
        {
            suhuValid = suhu >= 97.7 && suhu <= 99.5;
        }

        bool hariValid = hariDeman < config.BatasHariDeman;

        if (suhuValid && hariValid)
        {
            Console.WriteLine(config.PesanDiterima);
        }
        else
        {
            Console.WriteLine(config.PesanDitolak);
        }

        Console.WriteLine("\nMengubah satuan suhu...");
        config.UbahSatuan();
        Console.WriteLine($"Satuan suhu sekarang: {config.SatuanSuhu}");
    }
}
