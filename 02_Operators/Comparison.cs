using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 25;
            string userName = "Raymond";

            bool isEqual = (age == 41); // the value of isEqual depend son the comparison in the ()

            bool userIsMicheal = userName == "Micheal";

            Console.WriteLine(isEqual);
            Console.WriteLine(userIsMicheal);

            bool isNotEqual = age != 23;
            Console.WriteLine(isNotEqual);

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine(listsAreEqual);

            bool isGreaterThan = age > 36;
            Console.WriteLine(isGreaterThan); // false

            bool isLessThan = age < 36; 
            Console.WriteLine(isLessThan); // true

            bool isGreatOrEqual = age >= 41;
            Console.WriteLine(isGreatOrEqual); // false

            bool isTrue = true;
            bool isFalse = false;

            bool andValue = isTrue && isFalse; // true

            bool anotherAndValue = age == 25 && userName == "Raymond"; //true
            bool orValue = age == 25 || userName == "Micheal"; //true
        }
    }
}
