using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void SwitchCases()
        {
            int input = 1;

            switch (input)
            {
                case 1:
                    Console.WriteLine("hello");
                    break;
                case 2:
                    Console.WriteLine("world");
                    break;
                case 55:
                    Console.WriteLine("Eh?");
                    break;
                default:
                    Console.WriteLine("what are you doing?");
                    break;
            }
        }
    }
}
