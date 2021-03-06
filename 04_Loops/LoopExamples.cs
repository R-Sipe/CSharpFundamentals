using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            while (total != 10)
            {
                Console.WriteLine(total);

                total = total + 1;
            }

            int someCount = 0;
            bool keepLooping = true;

            while (keepLooping)
            {
                if (someCount <= 100)
                {
                    Console.WriteLine(someCount);
                    someCount++; // same as someCount = someCount + 1;
                }
                else
                {
                    keepLooping = false;
                }
            }
        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 28;

            //1 Starting point
            //2 Condition
            //3 What to do after each loop
            //4 Body of the loop - what gets executed

                    //1             //2       //3
            for (int i = 0; i < studentCount; i++)
            {
                //4
                Console.WriteLine(i);
            }
            int e = 0;

            //you could also use a while loop to do the same thing 
            while (e < studentCount)
            {
                // this will add one before the number resulting in 28 
                Console.WriteLine(++e);

            }
        }

        [TestMethod]
        public void ForEachLoops()
        {
            string[] students = { "Aaron", "Alexandro", "Ben", "Chris" };

            //1 Collection being worked on
            //2 Name of the current interaction
            //3 Type being held in the collection
            //4 in keyword

                      //3      2    4     1
            foreach (string student in students)
            {
                Console.WriteLine(student + " is a student in this class");
            }

            string myName = "Raymond Sipes";

            foreach (char letter in myName)
            {
                Console.Write(letter);
            }
        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello");
                Console.WriteLine(iterator);
                iterator++;
            }
            while (iterator < 5);
        }

    }
}
