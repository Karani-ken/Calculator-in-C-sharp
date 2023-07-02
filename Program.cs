using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_project.methods;
namespace Calculator_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calculator = new Calculate();
            int firstNum;
            int secondNum;
            string Operator;
            Console.WriteLine("Calculator");
            Console.WriteLine("Enter the operator either: +/-/*//");
            Operator=Console.ReadLine();
            if(Operator == "+")
            {
                Console.WriteLine("Enter first Number");
                firstNum = Int32.Parse( Console.ReadLine());
                Console.WriteLine("Enter second Number");
                secondNum= Int32.Parse( Console.ReadLine());
                int result = calculator.Add(firstNum, secondNum);
                Console.WriteLine($"Your answer is: {result}");
               

            }else if(Operator == "-")
            {
                Console.WriteLine("Enter first Number");
                firstNum = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter second Number");
                secondNum = Int32.Parse(Console.ReadLine());
               int result = calculator.Subtract(firstNum, secondNum);
                Console.WriteLine($"Your answer is: {result}");
            }
            else if (Operator == "*")
            {
                Console.WriteLine("Enter first Number");
                firstNum = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter second Number");
                secondNum = Int32.Parse(Console.ReadLine());
                int result = calculator.Multiply(firstNum, secondNum);
                Console.WriteLine($"Your answer is: {result}");
            }
            else if (Operator == "/")
            {
                Console.WriteLine("Enter first Number");
                firstNum = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter second Number");
                secondNum = Int32.Parse(Console.ReadLine());
                double result = calculator.Divide(firstNum, secondNum);
                Console.WriteLine($"Your answer is: {result}");
            }
            else
            {
                Console.WriteLine("Invalid Operator!!");
            }

            Console.ReadLine();

        }
    }
}
