using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculator
{
    public class ThirdBrand : PhoneBrand
    {
        public ThirdBrand() 
        {
             Name = "Third Brand";

        }
        public override double Calculate(double a, double b, char op)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                  
                    if (a != 0)
                    {
                        return a / b;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                        return 0;
                    }
                case '%':
                   
                    return a % b;
                case '^':                        // additional operation for third phone brand..
                    
                    return Math.Pow(a, b);
                default:
                    Console.WriteLine("Invalid operator!");
                    return 0;
            }
        }

        public override void DisplayResult(double num1, double num2, char op, double result, string Name)
        {
           
            Console.WriteLine($"  {Name} phone: {num1} {op} {num2} = {result}  ");
        }
    }

}
   
