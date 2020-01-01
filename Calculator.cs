using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_WPF_CalculatorApp_Using_ClassLibrary
{
    public class Calculator
    {
        // class libraries are used as collections for executable projects, but they cannot execute themselves
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        public int Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
        public int Divide(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }
        public int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
        //public decimal BMI(decimal wight, decimal height)
        //{
        //    bmi = Math.Pow(weight / height, 2)
        //        return Math.Round(bmi, 2)
        //}
    }
}
