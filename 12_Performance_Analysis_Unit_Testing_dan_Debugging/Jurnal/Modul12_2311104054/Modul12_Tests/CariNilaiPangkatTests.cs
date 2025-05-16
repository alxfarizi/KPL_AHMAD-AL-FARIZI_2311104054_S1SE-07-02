using NUnit.Framework;
using Modul12_Lib;

namespace Modul12_Tests
{
    public class CariNilaiPangkatTests
    {
        [Test]
        public void TestPangkatPositif()
        {
            double hasil = Program.CariNilaiPangkat(2, 3);
            Assert.That(hasil, Is.EqualTo(8));
        }

        [Test]
        public void TestPangkatNol()
        {
            double hasil = Program.CariNilaiPangkat(5, 0);
            Assert.That(hasil, Is.EqualTo(1));
        }

        [Test]
        public void TestPangkatNegatif()
        {
            double hasil = Program.CariNilaiPangkat(2, -2);
            Assert.That(hasil, Is.EqualTo(0.25));
        }
    }
}
