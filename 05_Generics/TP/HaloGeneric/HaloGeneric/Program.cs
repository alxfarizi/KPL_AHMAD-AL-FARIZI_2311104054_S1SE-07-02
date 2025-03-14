using System;

namespace tpmodul5_2311104054
{
    public class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric<string> halo = new HaloGeneric<string>("Fariz");
            halo.SapaUser();

            DataGeneric<string> data = new DataGeneric<string>("2311104054");
            data.PrintData();
        }
    }
}
