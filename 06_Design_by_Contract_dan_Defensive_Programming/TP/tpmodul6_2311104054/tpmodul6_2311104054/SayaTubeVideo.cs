using System;
namespace tpmodul6_2311104054
{
	public class SayaTubeVideo
	{
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {this.id}");
            Console.WriteLine($"Title: {this.title}");
            Console.WriteLine($"Play Count: {this.playCount}");
        }
    }
}

