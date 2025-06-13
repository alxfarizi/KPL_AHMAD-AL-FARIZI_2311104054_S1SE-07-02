using System;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string filePath = "users.json";
        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, JsonConvert.SerializeObject(new { users = new List<UserHandler.User>() }));
        }

        while (true)
        {
            Console.WriteLine("\nImplementasi TP Modul 2");
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Registrasi User");
            Console.WriteLine("2. Login User");
            Console.WriteLine("3. Keluar");
            Console.Write("Pilih opsi: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    UserHandler.RegisterUser(filePath);
                    break;
                case "2":
                    UserHandler.LoginUser(filePath);
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opsi tidak valid.");
                    break;
            }
        }
    }
}
