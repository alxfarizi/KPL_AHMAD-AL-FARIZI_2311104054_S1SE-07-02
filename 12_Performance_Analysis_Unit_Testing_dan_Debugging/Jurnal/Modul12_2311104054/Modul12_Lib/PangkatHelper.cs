namespace Modul12_Lib;

public class PangkatHelper
{
    public static int CariNilaiPangkat(int a, int b)
    {
        if (b == 0) return 1;
        if (a < 0 || b < 0) return -1;
        if (b > 10 || a > 100) return -2;

        int result = 1;
        try
        {
            checked
            {
                for (int i = 0; i < b; i++)
                {
                    result *= a;
                }
            }
        }
        catch (OverflowException)
        {
            return -3;
        }

        return result;
    }
}
