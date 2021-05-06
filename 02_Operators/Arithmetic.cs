using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void Operators()
        {
            int a = 22;
            int b = 15;

            //Addition
            int sum = a + b;
            Console.WriteLine(sum); //37
            
            //Subtraction
            int difference = a - b;
            Console.WriteLine(difference); //7
            
            //Multiplication
            int product = a * b;
            Console.WriteLine(product); //330
            
            //Division
            int quotient = a / b;
            Console.WriteLine(quotient); //1

            //Remainder (Modulus)
            int remainder = a % b;
            Console.WriteLine(remainder); //7
        }
    }
}
