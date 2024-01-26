using Nest;
using System;

namespace OOPCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double a ,b ;
            char op;
            string Name;


            Console.Write("Enter the first number: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operator (+, -, *, /, %, ^): ");
            op = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter the second number: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of phone brands: ");
            int numberOfBrands = int.Parse(Console.ReadLine());

           
            PhoneBrand[] brands = new PhoneBrand[numberOfBrands];

            for (int i = 0; i < numberOfBrands; i++)
            {
                Console.Write($"Enter the name of brand {i + 1}: ");
                string brandName = Console.ReadLine();

                switch (brandName.ToLower())
                {
                    case "First Brand":
                        brands[i] = new FirstBrand();
                        break;
                    case "Second Brand":
                        brands[i] = new SecondBrand();
                        break;
                    case "Third Brand":
                        brands[i] = new ThirdBrand();
                        break;
                    default:
                        Console.WriteLine("Invalid brand name. Please enter 'first', 'second', or 'third'.");
                        i--; 
                        break;
                }
            }
            foreach (PhoneBrand brand in brands)
            {
               
                double result = brand.Calculate(a, b, op);

              
                brand.DisplayResult(a, b, op, result, Name);
            }
        }
    }
}