using System;

class Program
{
    static void Main(string[] args)
    {
        // Jalankan KodePos
        KodePos kodePos = new KodePos();
        Console.WriteLine("Kode Pos Batumunggal: " + kodePos.GetKodePos("Batumunggal")); // Output: 40266
        Console.WriteLine("Kode Pos Maleer: " + kodePos.GetKodePos("Maleer"));          // Output: 40274
        Console.WriteLine("Kode Pos Unknown: " + kodePos.GetKodePos("Unknown"));       // Output: Kode pos tidak ditemukan

        // Jalankan DoorMachine
        DoorMachine door = new DoorMachine(); // State awal: Terkunci
        door.ChangeState("Terbuka");  // Output: Pintu tidak terkunci
        door.ChangeState("Terkunci"); // Output: Pintu terkunci

        Console.ReadLine();
    }
}