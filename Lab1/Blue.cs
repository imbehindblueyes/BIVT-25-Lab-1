using System.Diagnostics.CodeAnalysis;
using System.Security;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (a * b > 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            int cd = (int)d;
            double nd = d - cd;
            if (nd > 0)
            {
                if (nd > 0.0001)
                {
                    answer = true;
                }
            }
            if (nd < 0)
            {
                if (-nd > 0.0001)
                {
                    answer = true;
                }
            }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0 && a % b == 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double absd = Math.Abs(d);
            double absf = Math.Abs(f);
            double absg = Math.Abs(g);
            if (absd >= absf && absd >= absg)
            {
                answer = d;
            }
            if (absf > absd && absf >= absg)
            {
                answer = f;
            }
            if (absg > absd && absg > absf)
            {
                answer = g;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1.0)
            {
                answer = 0;
            }
            if (x > -1.0 && x <= 0.0)
            {
                answer = x + 1.0;
            }
            if (x > 0)
            {
                answer = 1;
            }
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double circleR = circleS / Math.PI;
            if (squareS >= circleR * 4)
            {
                answer = true;
            }
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f))
            { 
                if (d > 0)
                {
                    answer = -1;
                }
            }
            else
            { 
                if (f > 0)
                {
                    answer = 1;
                }
            }
                // end

                return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int ha = a / 2;
            int hb = b / 2;
            int hc = c / 2;
            int sum = ha + hb + hc;
            if (sum >= 2)
            {
                if (sum % 3 == 0 || (sum + 1) % 3 == 0)
                {
                    answer = true;
                }
            }
            // end

            return answer;
        }
    }
}