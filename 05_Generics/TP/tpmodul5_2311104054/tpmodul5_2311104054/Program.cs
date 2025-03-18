using System;
using tpmodul5_2311104054;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Masukkan nama pengguna: ");
        string inputUser = Console.ReadLine(); 

        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser(inputUser); 
    }
}
