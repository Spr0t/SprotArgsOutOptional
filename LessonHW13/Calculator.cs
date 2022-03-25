using System;

namespace LessonHW13
{
    internal class Calculator
    {
        public double Average(int[] numbers)
        {

            double sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum / numbers.Length;

        }

        public double Avarage2(params int[] numbers1)
        {
            double sum1 = 0;

            foreach (int n in numbers1)
            {
                sum1 += n;
            }
            return sum1 / numbers1.Length;

        }

        public double CalcTriangleSquare(int ab, int bc, int ac)
        {

            double p = (ab + bc + ac)/2;

            double square = Math.Sqrt(p*(p - ab)*(p - bc)*(p - ac));

            return square;

        }

        public bool TryDivide(double divisible, double divisor, out double result)
        {
            result = 0;
            if (divisor == 0)
            {
                return false;
            }
            result = divisible / divisor;
            return true;
        }
        
        public double CalcTriangleSquare2 (double ab,double ac, int alpha, bool isInRadiance = false)
        {
            if(isInRadiance)
            {
                return 0.5 * ab * ac * Math.Sin(alpha);
            }
            else
            {
                double rads = alpha * Math.PI / 180;
                return 0.5 * ab * ac * Math.Sin(rads);
            }



        }




    }




}
