using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212_UnitTestStarterCode
{
    /*****************************************************************************
     * 
     * YOU MAY REFACTOR THE PARAMETER NAMES BUT DO NOT CHANGE THE METHOD SIGNATURES
     * 
     * ***************************************************************************/
    public static class SimpleMath
    {
        public static double MathSolution { get; private set; }

        public static double Add(double a, double b)
        {
            double mathSolution = a + b;
            return mathSolution;
        }

        public static double Subtract(double a, double b)
        {
            double mathSolution = a - b;
            return mathSolution;
        }

        public static double Multiply(double a, double b)
        {
            double mathSolution = a * b;
            return mathSolution;
        }

        public static double Divide(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                throw new ArithmeticException("Can not divide by 0.");
            }
            double mathSolution = a / b;
            return mathSolution;
        }
    }
}
