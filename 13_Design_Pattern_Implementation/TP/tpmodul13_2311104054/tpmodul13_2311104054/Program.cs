using System;

namespace tpmodul13_2311104054
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsAgency univ = new NewsAgency();

            NewsChannel mhs = new NewsChannel("Dosen");
            NewsChannel dsn = new NewsChannel("Mahasiswa");

            univ.Attach(mhs);
            univ.Attach(dsn);

            univ.Notify("Berita Terkini, Desain Pattern Observer Dipelajari!");

            univ.Detach(mhs);
            univ.Notify("Berita Lanjutan, Mahasiswa Sudah Unsubscribe.");
        }
    }
}
