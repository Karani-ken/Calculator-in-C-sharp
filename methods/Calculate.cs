using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_project.methods
{
    public class Calculate
    {
        public int Num1;
        public int Num2;
        public int Add(int x, int y)
        {
            int result;
            Num1 = x;
            Num2 = y;
            result = Num1 + Num2;
            return result;
        }
        public int Subtract(int x, int y)
        {
            int result;
            Num1=x; Num2=y;
            result = Num1 - Num2;
            return result;
        }
        public int Multiply(int x, int y)
        {
            int result;
            Num1=x; Num2=y;
            result = Num1 * Num2;
            return result;
        }
        public double Divide(int x, int y)
        {
            double result;
            Num1=x; Num2=y;
            result = Num1 / Num2;
            return result;
        }
    }
}
