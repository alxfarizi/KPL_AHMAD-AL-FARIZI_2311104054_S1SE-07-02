namespace tpmodul12_2311104054
{
    public class BilanganHelper
    {
        public string CariTandaBilangan(int number)
        {
            if (number > 0)
                return "Positif";
            else if (number < 0)
                return "Negatif";
            else
                return "Nol";
        }
    }
}
