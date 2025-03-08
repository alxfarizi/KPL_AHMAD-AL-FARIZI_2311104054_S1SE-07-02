using System;

class Program
{
    static void Main(string[] args)
    {
        // Jalankan KodePos
        KodePos kodePos = new KodePos();
        kodePos.getKodePos();

        // Jalankan DoorMachine
        DoorMachine door = new DoorMachine(); // State awal: Terkunci
        door.ChangeState("Terbuka");  // Output: Pintu tidak terkunci
        door.ChangeState("Terkunci"); // Output: Pintu terkunci

        // Menahan console agar tidak langsung tertutup
        Console.WriteLine("\nTekan Enter untuk keluar...");
        Console.ReadLine();
    }
}