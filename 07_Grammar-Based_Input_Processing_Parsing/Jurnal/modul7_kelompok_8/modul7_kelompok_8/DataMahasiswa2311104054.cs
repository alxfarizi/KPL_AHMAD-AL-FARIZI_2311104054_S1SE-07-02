using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace modul7_2311104054
{
    internal class DataMahasiswa2311104054
    {
        public class Mahasiswa
        {
            [JsonPropertyName("firstName")]
            public string? FirstName { get; set; }

            [JsonPropertyName("lastName")]
            public string? LastName { get; set; }

            [JsonPropertyName("gender")]
            public string? Gender { get; set; }

            [JsonPropertyName("age")]
            public int Age { get; set; }

            [JsonPropertyName("address")]
            public Address? Address { get; set; }

            [JsonPropertyName("courses")]
            public List<Course>? Courses { get; set; }
        }

        public class Address
        {
            [JsonPropertyName("streetAddress")]
            public string? StreetAddress { get; set; }

            [JsonPropertyName("city")]
            public string? City { get; set; }

            [JsonPropertyName("state")]
            public string? State { get; set; }
        }

        public class Course
        {
            [JsonPropertyName("code")]
            public string? Code { get; set; }

            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }

        public static void ReadJson()
        {
            string pathFile = Path.Combine(Directory.GetCurrentDirectory(), "jurnal7_1_2311104054.json");
            Console.WriteLine($"Mencoba membaca file JSON di lokasi: {pathFile}");

            if (File.Exists(pathFile))
            {
                try
                {
                    string jsonData = File.ReadAllText(pathFile);
                    Mahasiswa? mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonData);

                    if (mahasiswa != null)
                    {
                        Console.WriteLine("Data Mahasiswa:");
                        Console.WriteLine($"Nama Lengkap : {mahasiswa.FirstName} {mahasiswa.LastName}");
                        Console.WriteLine($"Jenis Kelamin: {mahasiswa.Gender}");
                        Console.WriteLine($"Usia         : {mahasiswa.Age}");
                        Console.WriteLine("Alamat:");
                        Console.WriteLine($"  Jalan      : {mahasiswa.Address?.StreetAddress}");
                        Console.WriteLine($"  Kota       : {mahasiswa.Address?.City}");
                        Console.WriteLine($"  Provinsi   : {mahasiswa.Address?.State}");
                        Console.WriteLine("Mata Kuliah:");
                        if (mahasiswa.Courses != null)
                        {
                            foreach (var course in mahasiswa.Courses)
                            {
                                Console.WriteLine($"  - {course.Code} : {course.Name}");
                            }
                        }
                    }
                }
                catch (JsonException ex)
                {
                    Console.WriteLine($"Error parsing JSON: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("File tidak ditemukan.");
                Console.WriteLine($"Jalur file: {pathFile}");
            }
        }
    }
}
