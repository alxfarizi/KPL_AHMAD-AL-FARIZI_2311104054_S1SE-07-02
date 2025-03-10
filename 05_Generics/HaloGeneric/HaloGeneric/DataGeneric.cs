using System;
using Internal;

namespace tpmodul5_2311104054
{
	public class DataGeneric
	{
        private T data; // Field privat untuk menyimpan data

        // Constructor untuk inisialisasi data
        public DataGeneric(T data)
        {
            this.data = data;
        }

        // Method untuk mencetak data ke konsol
        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {data}");
        }
    }
}

