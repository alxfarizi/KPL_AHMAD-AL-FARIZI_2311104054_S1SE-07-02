using System;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Review Film Dune oleh Al - Farizi");
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film Dune Part Two oleh Al - Farizi");
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film Bumi Manusia oleh Al - Farizi");
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film Venom: The Last Dance oleh Al - Farizi");
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film Ant-Man and the Wasp: Quantumania oleh Al - Farizi");
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film Doctor Strange in the Multiverse of Madnessoleh Al - Farizi");
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film Captain America: Civil War oleh Al - Farizi");
        SayaTubeVideo video8 = new SayaTubeVideo("Review Film Home Town Cha Cha Cha oleh Al - Farizi");
        SayaTubeVideo video9 = new SayaTubeVideo("Review Film Exhuma oleh Al - Farizi");
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film Interstellar oleh Al - Farizi");

        video1.IncreasePlayCount(3);
        video2.IncreasePlayCount(5);
        video3.IncreasePlayCount(7);

        Console.WriteLine("Video Detail:");
        video1.PrintVideoDetails();
        Console.WriteLine();

        SayaTubeUser user = new SayaTubeUser("Al - Farizi");

        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);
        user.AddVideo(video4);
        user.AddVideo(video5);
        user.AddVideo(video6);
        user.AddVideo(video7);
        user.AddVideo(video8);
        user.AddVideo(video9);
        user.AddVideo(video10);

        Console.WriteLine("Semua Video:");
        user.PrintAllVideoPlaycount();
        Console.WriteLine($"Total Play Count: {user.GetTotalVideoPlayCount()}");

        Console.ReadLine();
    }
}