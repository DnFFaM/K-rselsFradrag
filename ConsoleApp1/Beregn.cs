using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KørselsFradrag
{
    public class Beregn
    {
        private double Kilometer;
        readonly private double Dage;
        readonly private int Choice;

        public Beregn(double kilometer, double dage, int choice)
        {
            Kilometer = kilometer;
            Dage = dage;
            Choice = choice;
        }

        public double KF()
        {
            if (Kilometer <= 24) // Hvis under 24
            {
                return 0;
            }

            double result = 0;

            if (Kilometer > 120) // hvis den er er over 120
            {
                double temp = Kilometer - 120;
                result = temp * 1.08;
                Kilometer -= temp;
            }

            result = (result + (Kilometer - 24) * 2.16 + BroPenge()) * Dage;

            return result;
        }
        public double BroPenge()
        {
            if (Choice == 1)
            {
                return 110 * 2;
            }
            if (Choice == 2)
            {
                return 50 * 2;
            }
            return 0;
        }
    }
}
/*
258km i alt

258km > 120km ? = true

258km - 120km = 138km

138km * 1.08dkk = 149,04dkk
258km - 138km = 120km

120km - 24km = 96km

96km * 2.16dkk = 207,36dkk

207,36dkk + 149,04dkk = 356,40dkk

356,40dkk + 220dkk = 576,40dkk
*/