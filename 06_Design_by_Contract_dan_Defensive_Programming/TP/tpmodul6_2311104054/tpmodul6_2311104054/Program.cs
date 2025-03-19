using tpmodul6_2311104054;

public class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [Ahmad Al - Farizi]");
        video.IncreasePlayCount(100);
        video.PrintVideoDetails();
    }
}