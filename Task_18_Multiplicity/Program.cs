using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18_Multiplicity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowlimitMultiples = 100;
            int highlimitMultiples = 1000;
            int numbersMultiples = 0;

            int lowDiapasoneDivider = 1;
            int highDiapasoneDivider = 28;

            Random random = new Random();
            int N = random.Next(lowDiapasoneDivider, highDiapasoneDivider);

            while (lowlimitMultiples != highlimitMultiples)
            {
                int temporarySum = 0;
                for (int i = 0; i < lowlimitMultiples; i += N)
                {
                    temporarySum += N;
                }

                if (temporarySum == lowlimitMultiples)
                    numbersMultiples++;

                lowlimitMultiples++;
            }

            Console.WriteLine(numbersMultiples);
        }
    }
}
