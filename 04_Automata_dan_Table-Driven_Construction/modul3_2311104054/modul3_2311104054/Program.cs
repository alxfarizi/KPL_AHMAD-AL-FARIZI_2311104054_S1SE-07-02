using System;

class Program
{
    static void Main(string[]args)
    {
        KodeBuah kodeBuah = new KodeBuah();
        kodeBuah.getKodeBuah();

        Console.WriteLine("----------------------------------------------------------------");

        Console.WriteLine("Simulasi PosisiKarakterGame dengan NIM: 2311104054 (NIM % 3 = 1)");
        Console.WriteLine("----------------------------------------------------------------");

        PosisiKarakterGame game = new PosisiKarakterGame();

        // Menguji semua transisi dan output yang diperlukan
        Console.WriteLine("\n1. Menekan tombol S (BERDIRI → JONGKOK):");
        game.PressS();

        Console.WriteLine("\n2. Menekan tombol S lagi (JONGKOK → TENGKURAP):");
        game.PressS();
        // Untuk NIM: 2311104054 % 3 = 1, mencetak "posisi istirahat"

        Console.WriteLine("\n3. Menekan tombol W (TENGKURAP → JONGKOK):");
        game.PressW();

        Console.WriteLine("\n4. Menekan tombol W lagi (JONGKOK → BERDIRI):");
        game.PressW();
        // Untuk NIM: 2311104054 % 3 = 1, mencetak "posisi standby"

        Console.WriteLine("\n5. Menekan tombol W lagi (BERDIRI → TERBANG):");
        game.PressW();

        Console.WriteLine("\n6. Menekan tombol S (TERBANG → BERDIRI):");
        game.PressS();
        // Untuk NIM: 2311104054 % 3 = 1, mencetak "posisi standby"

        Console.WriteLine("\n7. Mencoba menekan tombol X dari posisi BERDIRI:");
        game.PressX();

        Console.WriteLine("\n8. Menekan tombol S dua kali untuk mencapai TENGKURAP:");
        game.PressS(); // BERDIRI → JONGKOK
        game.PressS(); // JONGKOK → TENGKURAP
        // Untuk NIM: 2311104054 % 3 = 1, mencetak "posisi istirahat"

        Console.WriteLine("\n9. Menekan tombol X dari posisi TENGKURAP:");
        game.PressX(); // TENGKURAP → TERBANG

        Console.WriteLine("\n10. Menekan tombol S (TERBANG → BERDIRI):");
        game.PressS();
        // Untuk NIM: 2311104054 % 3 = 1, mencetak "posisi standby"

        Console.WriteLine("\nTekan enter untuk keluar...");
        Console.ReadLine();
    }
}

