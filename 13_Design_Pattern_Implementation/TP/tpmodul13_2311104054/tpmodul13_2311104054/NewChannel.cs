using System;

namespace tpmodul13_2311104054
{
    public class NewsChannel : IObserver
    {
        private string name;

        public NewsChannel(string name)
        {
            this.name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{name} menerima berita baru: {message}");
        }
    }
}
