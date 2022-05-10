using System;
using System.Collections.Generic;
using System.Text;

namespace Win_Calculator
{
    class Operators
    {
        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        public static Double Add(Double n1, Double n2)
        {
            return n1 + n2;
        }

        public static int Sub(int n1, int n2)
        {
            return n1 - n2;
        }

        public static Double Sub(Double n1, Double n2)
        {
            return n1 - n2;
        }

        public static int Multiplication(int n1, int n2)
        {
            return n1 * n2;
        }

        public static Double Multiplication(Double n1, Double n2)
        {
            return n1 * n2;
        }

        public static int Division(int n1, int n2)
        {
            return n1 / n2;
        }

        public static Double Division(Double n1, Double n2)
        {
            return n1 / n2;
        }

        public static int Sqrt(int n)
        {
            return (int)Math.Sqrt(n);
        }

        public static Double Sqrt(Double n)
        {
            return (Double)Math.Sqrt(n);
        }
    }
}