using System;

namespace MatematikaLibraries
{
    public class Matematika
    {
        public static int FPB(int input1, int input2)
        {
            while (input2 != 0)
            {
                int temp = input2;
                input2 = input1 % input2;
                input1 = temp;
            }
            return input1;
        }

        public static int KPK(int input1, int input2)
        {
            return (input1 * input2) / FPB(input1, input2);
        }

        public static string Turunan(int[] persamaan)
        {
            string hasil = "";
            for (int i = 0; i < persamaan.Length - 1; i++)
            {
                int koefisien = persamaan[i] * (persamaan.Length - 1 - i);
                int pangkat = persamaan.Length - 2 - i;

                if (koefisien != 0)
                {
                    if (hasil != "" && koefisien > 0)
                        hasil += " + ";
                    else if (koefisien < 0)
                        hasil += " - ";

                    hasil += Math.Abs(koefisien);
                    if (pangkat > 0)
                    {
                        hasil += "x";
                        if (pangkat > 1)
                            hasil += pangkat;
                    }
                }
            }
            return hasil == "" ? "0" : hasil;
        }

        public static string Integral(int[] persamaan)
        {
            string hasil = "";
            for (int i = 0; i < persamaan.Length; i++)
            {
                int pangkat = persamaan.Length - i;
                int koefisien = persamaan[i];

                if (koefisien != 0)
                {
                    if (hasil != "" && koefisien > 0)
                        hasil += " + ";
                    else if (koefisien < 0)
                        hasil += " - ";

                    hasil += Math.Abs(koefisien) + "/" + pangkat + "x";
                    if (pangkat > 1)
                        hasil += pangkat;


                }
            }
            return hasil;

        }
    }
}
