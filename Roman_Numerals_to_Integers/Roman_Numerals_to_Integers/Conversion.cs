using System;
using System.Collections.Generic;
using System.Text;

namespace Roman_Numerals_to_Integers
{
    class Conversion
    {
        //Given a string containing a roman numeral, return the integer value.
        //e.g., "XI" returns 11

        public void IntegerExchange(string roman)
        {
            int num = 0;
            int lastNumber = 0;
            roman = roman.ToUpper();

            for (int i = roman.Length - 1; i >= 0; i--)
            {
                char convertToDecimal = roman[i];

                switch (convertToDecimal)
                {
                    case 'M':
                        num = ProcessConversion(1000, lastNumber, num);
                        lastNumber = 1000;
                        break;

                    case 'D':
                        num = ProcessConversion(500, lastNumber, num);
                        lastNumber = 500;
                        break;

                    case 'C':
                        num = ProcessConversion(100, lastNumber, num);
                        lastNumber = 100;
                        break;

                    case 'L':
                        num = ProcessConversion(50, lastNumber, num);
                        lastNumber = 50;
                        break;

                    case 'X':
                        num = ProcessConversion(10, lastNumber, num);
                        lastNumber = 10;
                        break;

                    case 'V':
                        num = ProcessConversion(5, lastNumber, num);
                        lastNumber = 5;
                        break;

                    case 'I':
                        num = ProcessConversion(1, lastNumber, num);
                        lastNumber = 1;
                        break;

                    default:
                        Console.WriteLine("Please enter a roman numeral.");
                        break;
                }
            }
            Console.WriteLine(num);
            //Dictionary<string, int> dict = new Dictionary<string, int>
            //{
            //    {"M", 1000 }, //M = 1000
            //    {"CM", 900 },
            //    {"D", 500 }, //D = 500
            //    {"CD", 400 },
            //    {"C", 100 }, //C = 100
            //    {"XC", 90 },
            //    {"L", 50 }, //L = 50
            //    {"XL", 40 },
            //    {"X", 10 }, //X = 10
            //    {"IX", 9 },
            //    {"V", 5 }, //V = 5
            //    {"I", 1 } //I = 1
            //};
        }

        public int ProcessConversion(int num, int lastNumber, int lastDecimal)
        {
            if (lastNumber > num)
            {
                return lastDecimal - num;
            }
            else
            {
                return lastDecimal + num;
            }
        }
    }
}
