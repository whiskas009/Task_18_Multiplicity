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
            int lowlimit = 100;
            int highlimit = 1000;
            int numbersMultiples = 0;

            Random random = new Random();
            int N = random.Next(1, 27);

            while (lowlimit != highlimit)
            {
                int temporarySum = 0;
                for (int i = 0; i < lowlimit; i += N)
                {
                    temporarySum += N;
                }

                if (temporarySum == lowlimit)
                    numbersMultiples++;

                lowlimit++;
            }

            Console.WriteLine(numbersMultiples);
        }
    }
}
