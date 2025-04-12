using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GlossaryProject
{
    public class GlossDef
    {
        [JsonPropertyName("para")]
        public string Para { get; set; } = string.Empty;

        [JsonPropertyName("GlossSeeAlso")]
        public string[] GlossSeeAlso { get; set; } = Array.Empty<string>();
    }

    public class GlossEntry
    {
        [JsonPropertyName("ID")]
        public string ID { get; set; } = string.Empty;

        [JsonPropertyName("SortAs")]
        public string SortAs { get; set; } = string.Empty;

        [JsonPropertyName("GlossTerm")]
        public string GlossTerm { get; set; } = string.Empty;

        [JsonPropertyName("Acronym")]
        public string Acronym { get; set; } = string.Empty;

        [JsonPropertyName("Abbrev")]
        public string Abbrev { get; set; } = string.Empty;

        [JsonPropertyName("GlossDef")]
        public GlossDef GlossDef { get; set; } = new GlossDef();

        [JsonPropertyName("GlossSee")]
        public string GlossSee { get; set; } = string.Empty;
    }

    public class GlossList
    {
        [JsonPropertyName("GlossEntry")]
        public GlossEntry GlossEntry { get; set; } = new GlossEntry();
    }

    public class GlossDiv
    {
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("GlossList")]
        public GlossList GlossList { get; set; } = new GlossList();
    }

    public class Glossary
    {
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("GlossDiv")]
        public GlossDiv GlossDiv { get; set; } = new GlossDiv();
    }

    // Kelas utama GlossaryItem
    public class GlossaryItem2311104054
    {
        [JsonPropertyName("glossary")]
        public Glossary Glossary { get; set; } = new Glossary();

        public static void ReadJSON()
        {
            string pathFile = Path.Combine(Directory.GetCurrentDirectory(), "jurnal7_3_2311104054.json");

            if (!File.Exists(pathFile))
            {
                Console.WriteLine("File glossary.json tidak ditemukan");
                Console.WriteLine("Path yang dicari: " + pathFile);
                return;
            }

            try
            {
                string jsonData = File.ReadAllText(pathFile);
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    WriteIndented = true
                };

                GlossaryItem2311104054? glossaryItem = JsonSerializer.Deserialize<GlossaryItem2311104054>(jsonData, options);

                if (glossaryItem?.Glossary == null)
                {
                    Console.WriteLine("Data JSON tidak valid atau kosong");
                    return;
                }

                // Menampilkan informasi GlossEntry
                var entry = glossaryItem.Glossary.GlossDiv.GlossList.GlossEntry;
                Console.WriteLine("\n=== GlossEntry Information ===");
                Console.WriteLine($"ID: {entry.ID}");
                Console.WriteLine($"Sort As: {entry.SortAs}");
                Console.WriteLine($"Term: {entry.GlossTerm}");
                Console.WriteLine($"Acronym: {entry.Acronym}");
                Console.WriteLine($"Abbreviation: {entry.Abbrev}");
                Console.WriteLine($"Definition: {entry.GlossDef.Para}");
                Console.WriteLine($"See Also: {string.Join(", ", entry.GlossDef.GlossSeeAlso)}");
                Console.WriteLine($"See: {entry.GlossSee}");
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error parsing JSON: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}