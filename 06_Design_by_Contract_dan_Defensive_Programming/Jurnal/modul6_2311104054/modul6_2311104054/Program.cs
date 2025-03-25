using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            SayaTubeUser user = new SayaTubeUser("Ahmad Al - Farizi");

            string[] filmTitles = {
                "Peaky Blinders",
                "Hometown Cha-Cha-Cha",
                "Rise of Empires: Ottoman",
                "Morbious",
                "Dune",
                "Dune Part Two",
                "Money Heist",
                "Lupin",
                "Berlin",
                "Squid Game Part 2"
            };

            for (int i = 0; i < filmTitles.Length; i++)
            {
                SayaTubeVideo video = new SayaTubeVideo("Review Film " + filmTitles[i] + " oleh Ahmad Al - Farizi");
                video.IncreasePlayCount((i + 1) * 100000); 
                user.AddVideo(video);
            }

            user.PrintAllVideoPlaycount();

            Console.WriteLine("Total Play Count: " + user.GetTotalVideoPlayCount());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
