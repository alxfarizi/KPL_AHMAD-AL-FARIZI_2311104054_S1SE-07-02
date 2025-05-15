using Xunit;
using tpmodul12_2311104054;

namespace Tests
{
    public class CariTandaBilanganTests
    {
        [Theory]
        [InlineData(5, "Positif")]
        [InlineData(-5, "Negatif")]
        [InlineData(0, "Nol")]
        public void TestCariTandaBilangan(int input, string expected)
        {
            var helper = new BilanganHelper();
            var result = helper.CariTandaBilangan(input);
            Assert.Equal(expected, result);
        }
    }
}
