using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_C미쳼색
{
    public class Calculator
    {
        public static int Add(int n1, int n2)
        { return n1 + n2; }
        public static int Subtract(int n1, int n2) 
        {  return n1 - n2; }
        public static int Product(int n1, int n2)
        {  return n1 + n2; }
        public static double Quotient(int n1, int n2)
        {  return n1 * n2; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 5;

            //Calculator c  = new Calculator(); //-> static 안 썼을때
            int sum = Calculator.Add(num1, num2);
            int difference = Calculator.Subtract(num1, num2);
            int product = Calculator.Product(num1, num2);
            double qoutient = Calculator.Quotient(num1, num2);
                        
            Console.WriteLine(sum);
            Console.WriteLine(difference);
            Console.WriteLine(product);
            Console.WriteLine(qoutient);
        }
    }
}
