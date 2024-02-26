using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class WeightCalculation
    {
        public double Hight { get; set; }
        public char Gender { get; set; }

        public double GetWight()
        {
            switch (Gender)
            {
                case 'M':
                    return (Hight - 100) - ((Hight - 150) / 4);
                case 'F':
                    return (Hight - 100) - ((Hight - 150) / 2);
                default:
                    return 0;

            }
        }
    }
}
