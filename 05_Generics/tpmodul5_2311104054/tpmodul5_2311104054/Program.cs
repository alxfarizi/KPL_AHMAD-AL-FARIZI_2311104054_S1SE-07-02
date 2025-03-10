using System;

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Fariz");

        DataGeneric<string> data = new DataGeneric<string>("2311104054");
        data.PrintData();
    }
}
