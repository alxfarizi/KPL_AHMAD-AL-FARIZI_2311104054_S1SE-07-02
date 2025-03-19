using tpmodul6_2311104054;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [Ahmad Al - Farizi]");
            video.IncreasePlayCount(5000000);
            video.PrintVideoDetails();

            for (int i = 0; i < 3; i++)
            {
                video.IncreasePlayCount(250000000);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}