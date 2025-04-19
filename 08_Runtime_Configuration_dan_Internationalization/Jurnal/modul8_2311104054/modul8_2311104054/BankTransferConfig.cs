using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace modul8_2311104054
{
	public class BankTransferConfig
	{
        public string lang { get; set; } = "en";
        public TransferConfig transfer { get; set; } = new TransferConfig();
        public List<string> methods { get; set; } = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" };
        public ConfirmationConfig confirmation { get; set; } = new ConfirmationConfig();

        public class TransferConfig
        {
            public int threshold { get; set; } = 25000000; 
            public int low_fee { get; set; } = 6500;   
            public int high_fee { get; set; } = 15000;  
        }

        public class ConfirmationConfig
        {
            public string en { get; set; } = "yes";
            public string id { get; set; } = "ya";  
        }

        public static BankTransferConfig LoadConfig(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    return JsonSerializer.Deserialize<BankTransferConfig>(json);
                }
                else
                {
                    var defaultConfig = new BankTransferConfig();
                    SaveConfig(filePath, defaultConfig);
                    return defaultConfig;
                }
            }
            catch (Exception)
            {
                return new BankTransferConfig();
            }
        }

        public static void SaveConfig(string filePath, BankTransferConfig config)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(config, options);
                File.WriteAllText(filePath, json);
            }
            catch (Exception)
            {
            }
        }
    }
}

