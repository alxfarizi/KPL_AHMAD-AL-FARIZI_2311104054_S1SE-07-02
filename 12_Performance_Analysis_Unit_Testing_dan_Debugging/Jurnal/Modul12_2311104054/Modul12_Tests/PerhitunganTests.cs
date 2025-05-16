using NUnit.Framework;
using Modul12_Lib;

namespace Modul12_Tests
{
    public class PerhitunganTests
    {
        [Test]
        public void TestPenjumlahan()
        {
            int hasil = Perhitungan.Tambah(2, 3);
            Assert.That(hasil, Is.EqualTo(5));
        }

        [Test]
        public void TestPengurangan()
        {
            int hasil = Perhitungan.Kurang(10, 4);
            Assert.That(hasil, Is.EqualTo(6));
        }

        [Test]
        public void TestPerkalian()
        {
            int hasil = Perhitungan.Kali(3, 4);
            Assert.That(hasil, Is.EqualTo(12));
        }
    }
}
