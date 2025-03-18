using System;
namespace tpmodul5_2311104054
{
	public class HaloGeneric
	{
        public void SapaUser<T>(T input)
        {
            Console.WriteLine($"Halo user {input}"); // Mencetak sapaan dengan input
        }
    }
}

