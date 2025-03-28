﻿using System;
using System.Collections.Concurrent;

public class KodeBuah
{
	private Dictionary<string, string> kodeBuah;
	
	public KodeBuah()
	{
		kodeBuah = new Dictionary<string, string>
		{
			{"Apel", "A00"},
            {"Aprikot", "B00"},
            {"Alpukat", "C00"},
            {"Pisang", "D00"},
            {"Paprika", "E00"},
            {"Blackberry", "F00"},
            {"Ceri", "H00"},
            {"Kelapa", "I00"},
            {"Jagung", "J00"},
            {"Kurma", "K00"},
            {"Durian", "L00"},
            {"Anggur", "M00"},
            {"Melon", "N00"},
            {"Semangka", "O00"}
        };
	}
    public void getKodeBuah()
    {
        Console.WriteLine("+---------------+---------+");
        Console.WriteLine("|   Nama Buah   |Kode Buah|");
        Console.WriteLine("+---------------+---------+");

        foreach (var entry in kodeBuah)
        {
            Console.WriteLine($"| {entry.Key, -13} | {entry.Value,-8}|");
        }

        Console.WriteLine("+---------------+---------+");
    }
}

