using System;
using System.IO;
using System.Text.Json;

namespace tpmodul8_2311104054
{
	public class CovidConfig
	{
        private const string ConfigFile = "covid_config.json";
        private ConfigData configData;

        public CovidConfig()
        {
            LoadConfig();
        }

        private void LoadConfig()
        {
            try
            {
                if (File.Exists(ConfigFile))
                {
                    string json = File.ReadAllText(ConfigFile);
                    configData = JsonSerializer.Deserialize<ConfigData>(json);
                }
                else
                {
                    configData = new ConfigData
                    {
                        satuan_suhu = "celcius",
                        batas_hari_deman = 14,
                        pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini",
                        pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini"
                    };
                    SaveConfig();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading config: {ex.Message}");
                configData = new ConfigData
                {
                    satuan_suhu = "celcius",
                    batas_hari_deman = 14,
                    pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini",
                    pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini"
                };
            }
        }

        private void SaveConfig()
        {
            try
            {
                string json = JsonSerializer.Serialize(configData, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(ConfigFile, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving config: {ex.Message}");
            }
        }

        public string SatuanSuhu => configData.satuan_suhu;
        public int BatasHariDeman => configData.batas_hari_deman;
        public string PesanDitolak => configData.pesan_ditolak;
        public string PesanDiterima => configData.pesan_diterima;

        public void UbahSatuan()
        {
            configData.satuan_suhu = configData.satuan_suhu == "celcius" ? "fahrenheit" : "celcius";
            SaveConfig();
        }

        private class ConfigData
        {
            public string satuan_suhu { get; set; }
            public int batas_hari_deman { get; set; }
            public string pesan_ditolak { get; set; }
            public string pesan_diterima { get; set; }
        }
    }
}

