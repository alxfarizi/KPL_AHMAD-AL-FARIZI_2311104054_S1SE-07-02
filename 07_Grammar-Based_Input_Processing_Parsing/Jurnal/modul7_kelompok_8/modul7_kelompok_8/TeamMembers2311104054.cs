using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace modul7_2311104054
{
    public class TeamMember
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; } = string.Empty;

        [JsonPropertyName("lastName")]
        public string LastName { get; set; } = string.Empty;

        [JsonPropertyName("gender")]
        public string Gender { get; set; } = string.Empty;

        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("nim")]
        public string Nim { get; set; } = string.Empty;
    }

    public class TeamMembers2311104054
    {
        [JsonPropertyName("members")]
        public List<TeamMember> Members { get; set; } = new List<TeamMember>();

        public static void ReadJson()
        {
            string pathFile = Path.Combine(Directory.GetCurrentDirectory(), "jurnal7_2_2311104054.json");

            if (!File.Exists(pathFile))
            {
                Console.WriteLine("File tidak ditemukan");
                Console.WriteLine(pathFile);
                return;
            }

            try
            {
                string jsonData = File.ReadAllText(pathFile);
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                TeamMembers2311104054? team = JsonSerializer.Deserialize<TeamMembers2311104054>(jsonData, options);

                if (team?.Members == null)
                {
                    Console.WriteLine("Data JSON tidak valid atau kosong");
                    return;
                }

                Console.WriteLine("Team member list:");
                foreach (var member in team.Members)
                {
                    Console.WriteLine($"{member.Nim} {member.FirstName} {member.LastName} ({member.Age} {member.Gender})");
                }
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