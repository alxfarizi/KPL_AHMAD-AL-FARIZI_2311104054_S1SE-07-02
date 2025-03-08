using System;

class Program
{
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();
        kodePos.getKodePos();

        DoorMachine door = new DoorMachine(); 
        door.ChangeState("Terbuka");  

        // Menahan console agar tidak langsung tertutup
        Console.WriteLine("\nTekan Enter untuk keluar...");
        Console.ReadLine();
    }
}