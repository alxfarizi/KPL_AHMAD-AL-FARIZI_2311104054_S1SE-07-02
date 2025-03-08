using System;
using System.Collections.Generic;

public class KodePos
{
    private Dictionary<string, string> kodePos;

    public KodePos()
    {
        kodePos = new Dictionary<string, string>
        {
            { "Batumunggal", "40266" },
            { "Kujangsari", "40287" },
            { "Mengger", "40267" },
            { "Wates", "40256" },
            { "Cijaura", "40287" },
            { "Jatisari", "40286" },
            { "Margasari", "40286" },
            { "Sekejati", "40286" },
            { "Kebonwaru", "40272" },
            { "Maleer", "40274" }
        };
    }
    public void getKodePos()
    {
        Console.WriteLine("+---------------+---------+");
        Console.WriteLine("| Kelurahan     | KodePos |");
        Console.WriteLine("+---------------+---------+");

        foreach (var entry in kodePos)
        {
            Console.WriteLine($"| {entry.Key,-13} | {entry.Value,-7} |");
        }

        Console.WriteLine("+---------------+---------+");
    }
}