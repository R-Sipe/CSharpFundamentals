using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = true;
            if (userIsHungry)
            {
                Console.WriteLine("Eat something!");
            }

            int hoursSpendStudying = 1;
            if (hoursSpendStudying < 15)
            {
                Console.WriteLine("Are you even trying?");
            }
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = false;
            if (choresAreDone)
            {
                Console.WriteLine("Have fun watching Twitch!");
            }
            else
            {
                Console.WriteLine("Get your chores done loser lol");
            }

            string input = "7";
            int totalHours = int.Parse(input); 

            if(totalHours >= 8)
            {
                Console.WriteLine("You should be well rested!");
            }
            else
            {
                Console.WriteLine("You are sleep deprived moron");
                if(totalHours < 4)
                {
                    Console.WriteLine("You're not a real human");
                }
            }
        }

        [TestMethod]
        public void IfElseIfStatement()
        {
            int age = 55;

            if(age > 17)
            {
                Console.WriteLine("you're an adult");
            }
            else
            {
                if(age > 6)
                {
                    Console.WriteLine("you're a kid");
                }
                else if(age > 0)
                {
                    Console.WriteLine("You're a baby, how can you read this?");
                }
                else
                {
                    Console.WriteLine("You're not born weirdo");
                }
            }

            if(age < 65 && age > 18)
            {
                Console.WriteLine("Age is between 18 and 65");
            }
            if(age == 55)
            {
                Console.WriteLine("You're a Senior Citizen now sadge");
            }
        }
    }
}
