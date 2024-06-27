using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    public class MyCalc
    {
              
        public static double AddOperation(double firstInput, double secondInput)
        {
            return firstInput + secondInput;
        }
        public static double SubOperation(double firstInput, double secondInput)
        {
            return firstInput - secondInput;
        }

        public static double SquareOperation(double firstInput, double secondInput)
        {
            return Math.Pow(firstInput, secondInput);
        }

        public static double MultiplicationOperation(double firstInput, double secondInput)
        {
            return  firstInput * secondInput;
        }

        public static double DivisionOperation(double firstInput, double secondInput)
        {
            return firstInput / secondInput;
        }

        public static double ModuleOperation(double firstInput, double secondInput)
        {
            return firstInput % secondInput;
        }
       
    }
}
