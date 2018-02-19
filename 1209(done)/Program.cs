using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1209_done_
{
    class Program
    {
        private static double GetDoubleValue(string input)
        {
            double output = 0;
            int inputLength = input.Length;
            int decimalPosition = inputLength;
            var hasSeperator = false;
            var isNegative = input[0] == '-';

            for (int k = (isNegative ? 1 : 0); k < inputLength; k++)
            {
                char currentCharacter = input[k];

                if (currentCharacter == '.' || currentCharacter == ',')
                {
                    if (hasSeperator)
                    {
                        return Double.NaN;
                    }
                    else
                    {
                        hasSeperator = true;
                    }

                    decimalPosition = k + 1;
                }
                else
                {
                    var digitValue = currentCharacter - '0';

                    if (digitValue < 0 || digitValue > 9)
                    {
                        return Double.NaN;
                    }

                    output = (output * 10) + digitValue;
                }
            }

            var powDividend = CustomPow(10, inputLength - decimalPosition);
            var integer = ((isNegative ? -1 : 1) * output);

            return integer / powDividend;
        }

        private static double CustomPow(int num, int exp)
        {
            double result = 1.0;

            while (exp > 0)
            {
                if ((exp & 1) == 1)
                {
                    result *= num;
                }

                exp >>= 1;
                num *= num;
            }

            return result;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = "";
            for (int i = 0; i < n; i++)
            {
                double m = GetDoubleValue(Console.ReadLine());
                double temp = Math.Sqrt(8 * m - 7);
                bool isIntegral = (temp % 1) == 0;
                if (isIntegral) s += 1 + " ";
                else s += 0 + " ";

            }
            Console.WriteLine(s);


         //   Console.ReadLine();
        }
    }
}
