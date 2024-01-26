using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculator
{
    public abstract class PhoneBrand
    {
        public string? Name { get; set; }
        public abstract double Calculate(double a, double b, char op);

        public virtual void DisplayResult(double a, double b, char op, double result, string Name)
        {
            Console.WriteLine($"{Name} phone: {a} {op} {b} = {result}");
        }
    }
}

