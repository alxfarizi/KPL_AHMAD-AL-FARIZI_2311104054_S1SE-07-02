using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace modul7_2311104054
{
    class Article
    {
        [JsonPropertyName("title")]
        public string Judul { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }
    }

    internal class Jurnal
    {
        [JsonPropertyName("journal_name")]
        public string JournalName { get; set; }

        [JsonPropertyName("articles")]
        public List<Article> Articles { get; set; }

        [JsonPropertyName("volume")]
        public int Volume { get; set; }

        [JsonPropertyName("tahun_terbit")]
        public int TahunTerbit { get; set; }

        public static void ReadJson()
        {
            string pathFile = Path.Combine(Directory.GetCurrentDirectory(), "jurnal.json");
            if (File.Exists(pathFile))
            {
                try
                {
                    string jsonData = File.ReadAllText(pathFile);
                    Jurnal jurnal = JsonSerializer.Deserialize<Jurnal>(jsonData);

                    Console.WriteLine($"Judul jurnal: {jurnal.JournalName}");
                    Console.WriteLine("List artikel:");
                    int index = 1;
                    foreach (var artikel in jurnal.Articles)
                    {
                        Console.WriteLine($"Judul artikel {index}: {artikel.Judul}");
                        Console.WriteLine($"Author artikel {index}: {artikel.Author}");
                        index++;
                    }

                    Console.WriteLine($"Volume: {jurnal.Volume}");
                    Console.WriteLine($"Tahun terbit: {jurnal.TahunTerbit}");
                }
                catch (JsonException ex)
                {
                    Console.WriteLine($"Error parsing JSON: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("File tidak ditemukan");
                Console.WriteLine(pathFile);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Jurnal.ReadJson();
        }
    }
}
