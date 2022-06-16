using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc1
{
    internal class MathOp
    {
        public static string Add(string num1, string num2)
        {
            double a, b;
            if (!Double.TryParse(num1, out a) || !Double.TryParse(num2, out b)) { return null; }
            return Math.Round((a + b), 5).ToString();
        }
        public static string Sub(string num1, string num2)
        {
            double a, b;
            if (!Double.TryParse(num1, out a) || !Double.TryParse(num2, out b)) { return null; }
            return Math.Round((a - b), 5).ToString();
        }
        public static string Mul(string num1, string num2)
        {
            double a, b;
            if (!Double.TryParse(num1, out a) || !Double.TryParse(num2, out b)) { return null; }
            return Math.Round((a * b), 5).ToString();
        }
        public static string Dev(string num1, string num2)
        {
            double a, b;
            if (!Double.TryParse(num1, out a) || !Double.TryParse(num2, out b)) { return null; }
            return Math.Round((a / b), 5).ToString();
        }
        public static string Sqrt(string num1)
        {
            double a;
            if (!Double.TryParse(num1, out a)) { return null; }
            return Math.Round(Math.Sqrt(a), 5).ToString();
        }
        public static string Pow(string num1)
        {
            double a;
            if (!Double.TryParse(num1, out a)) { return null; }
            return Math.Round(Math.Pow(a, 2), 5).ToString();
        }
        public static string OneDev(string num1)
        {
            double a;
            if (!Double.TryParse(num1, out a)) { return null; }
            return Math.Round((1 / a), 5).ToString();
        }
        public static string Factorial(string num1)
        {
            double a, n = 1;
            if (!Double.TryParse(num1, out a)) { return null; }
            for (int i = 1; i <= a; i++)
            {
                n *= i;
            }
            return (n).ToString();
        }
        public static string Proc(string num1, string num2)
        {
            double a, b;
            if (!Double.TryParse(num1, out a) || !Double.TryParse(num2, out b)) { return null; }
            return (a * b / 100).ToString();
        }
        public static string Log(string num1)
        {
            double a;
            if (!Double.TryParse(num1, out a)) { return null; }
            return Math.Log10(a).ToString();
        }
        public static string Ln(string num1)
        {
            double a;
            if (!Double.TryParse(num1, out a)) { return null; }
            return Math.Log(a, Math.E).ToString();
        }
        public static string Pow2(string num1, string num2)
        {
            double a, b;
            if (!Double.TryParse(num1, out a) || !Double.TryParse(num2, out b)) { return null; }
            return Math.Pow(a, b).ToString();
        }
        public static string Pow10(string num1)
        {
            double a;
            if (!Double.TryParse(num1, out a)) { return null; }
            return Math.Pow(10, a).ToString();
        }
        public static string PowEx(string num1)
        {
            double a;
            if (!Double.TryParse(num1, out a)) { return null; }
            return Math.Pow(2.72, a).ToString();
        }
        public static string Abs(string num1)
        {
            double a;
            if (!Double.TryParse(num1, out a)) { return null; }
            return Math.Abs(a).ToString();
        }
        public static string Sin(string num1)
        {
            double a;
            if (!Double.TryParse(num1, out a)) { return null; }
           
            return Math.Round(Math.Sin(a * 0.0175),3).ToString();
        }
        public static string Cos(string num1)
        {
            double a;
            if (!Double.TryParse(num1, out a)) { return null; }
            return Math.Round(Math.Cos(a* 0.0175), 3).ToString();
        }
        public static string Tan(string num1)
        {
            double a;
            if (!Double.TryParse(num1, out a)) { return null; }
            return Math.Round(Math.Tan(a*0.0175),3).ToString();
        }
        public static string Cot(string num1)
        {
            double a;
            if (!Double.TryParse(num1, out a)) { return null; }
            return Math.Round((1 / Math.Tan(a* 0.0175)), 3).ToString();
        }
    }
}
