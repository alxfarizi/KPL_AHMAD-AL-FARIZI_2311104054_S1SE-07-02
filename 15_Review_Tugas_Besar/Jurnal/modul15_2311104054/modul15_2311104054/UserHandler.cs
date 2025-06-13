using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

class UserHandler
{
    public static void RegisterUser(string filePath)
    {
        Console.Write("Masukkan username: ");
        string username = Console.ReadLine();

        if (!Validation.IsValidUsername(username))
        {
            Console.WriteLine("Username hanya boleh huruf alfabet ASCII.");
            return;
        }

        Console.Write("Masukkan password: ");
        string password = Console.ReadLine();

        if (!Validation.IsValidPassword(password))
        {
            Console.WriteLine("Password harus 8-20 karakter, mengandung angka dan karakter unik (!@#$%^&*).");
            return;
        }

        string hashedPassword = Security.HashPassword(password);

        var users = FileHandler.LoadUsers(filePath);
        users.Add(new User { Username = username, Password = hashedPassword });
        FileHandler.SaveUsers(filePath, users);

        Console.WriteLine("Registrasi berhasil.");
    }

    public static void LoginUser(string filePath)
    {
        Console.Write("Masukkan username: ");
        string username = Console.ReadLine();

        Console.Write("Masukkan password: ");
        string password = Console.ReadLine();

        string hashedPassword = Security.HashPassword(password);

        var users = FileHandler.LoadUsers(filePath);
        foreach (var user in users)
        {
            if (user.Username == username && user.Password == hashedPassword)
            {
                Console.WriteLine("Login berhasil. Selamat datang!");
                return;
            }
        }

        Console.WriteLine("Login gagal. Username atau password salah.");
    }

    public class User
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
