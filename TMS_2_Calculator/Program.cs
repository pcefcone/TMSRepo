using System;
using System.Globalization;
using Calculator;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCalc calc = new MyCalc();
            
            Console.WriteLine("Put first number: ");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Put second number: ");
            string secondNumber = Console.ReadLine();
            Console.WriteLine("Please choose the following you want to do");
            Console.WriteLine("Choose '+' to calculate the addition");
            Console.WriteLine("Choose '-' to calculate the substraction");
            Console.WriteLine("Choose '*' to calculate the multiplication");
            Console.WriteLine("Choose '/' to calculate the division");
            Console.WriteLine("Choose '^' to calculate the exponentiation");
            Console.WriteLine("Choose '%' to calculate the module");
            Console.WriteLine("Your choose is: ");

            switch (Console.ReadLine())
            {
                // addition
                case "+":
                    Console.WriteLine(value: $"Your result is: " +
                        $"{MyCalc.AddOperation(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber))}");
                    break;

                // substraction
                case "-":
                    Console.WriteLine(value: $"Your result is: " +
                        $"{MyCalc.SubOperation(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber))}"); ;
                    break;

                // multiplication
                case "*":
                    Console.WriteLine(value: $"Your result is: " +
                        $"{MyCalc.MultiplicationOperation(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber))}");
                    break;

                // division
                case "/":
                    Console.WriteLine(value: $"Your result is: " +
                        $"{MyCalc.DivisionOperation(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber))}");
                    break;

                // square
                case "^":
                    Console.WriteLine(value: $"Your result is: " +
                        $"{MyCalc.SquareOperation(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber))}");
                    break;

                // square
                case "%":
                    Console.WriteLine(value: $"Your result is: " +
                        $"{MyCalc.ModuleOperation(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber))}");
                    break;

                default:
                    Console.WriteLine("Unknown operaion, please try again");
                    break;
            }
            Console.ReadKey();
        }
    }
}


