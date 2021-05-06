using _08_Interfaces.Fruit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _08_Interfaces
{
    [TestClass]
    public class IFruitTest
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            IFruit banana = new Banana();
            Banana banana1 = new Banana();
            //Cant create an interface object
            //IFruit banana = new IFruit();

            //var is like a wildcard argument
            var output = banana.Peel();
            Console.WriteLine(output);

            Console.WriteLine("The banana is peeled: " + banana.IsPeeled);
            Assert.IsTrue(banana.IsPeeled);

        }

        [TestMethod]
        public void InterfacesInCollections()
        {
            Orange orange = new Orange();

            //var allows different fruits using the IFruit interface to exist together
            var fruitSalad = new List<IFruit>
            {
                new Banana(),
                new Orange(),
                orange

                //Orange exclusive methods still accesible outside of IFruit collection
            };
            orange.Squeeze();

            foreach (var fruit in fruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());
                //no longer accesible once in a collection
                //fruit.squeeze

                Assert.IsInstanceOfType(fruit, typeof(IFruit));
            }

            Assert.IsInstanceOfType(orange, typeof(Orange));
        }

        private string GetFruitName(IFruit fruit)
        {
            return $"This fruit is called {fruit.Name}";
        }

        [TestMethod]
        public void InterfacesInMethods()
        {
            var grape = new Grape();

            //even though the method only takes IFruit, grap still qualifies
            string output = GetFruitName(grape);

            Console.WriteLine(output);
        }

        [TestMethod]
        public void TypeOfInstance()
        {
            var fruitSalad = new List<IFruit>
            {
                new Orange(true),
                new Orange(),
                new Grape(),
                new Orange(),
                new Banana(true),
                new Grape()
            };

            Console.WriteLine("Is the orange peeled?");
            foreach(var fruit in fruitSalad)
            {
                //Checking its of type orange, casting it as orange
                //Pattern Matching
                if (fruit is Orange orange)
                {
                    if (orange.IsPeeled)
                    {
                        Console.WriteLine("It is a peeled orange");
                        //regain orange exclusive properties
                        Console.WriteLine(orange.Squeeze());
                    }
                    else
                    {
                        Console.WriteLine("Its an orange");
                    }
                }
                else if (fruit.GetType() == typeof(Grape))
                {
                    Console.WriteLine("Its a grape");

                    //without pattern mathcing, casting is necessary
                    var grape = (Grape)fruit;
                    Console.WriteLine(grape.Peel());
                }
                else if (fruit.IsPeeled)
                {
                    Console.WriteLine("Its a peeled banana");
                }
                else
                {
                    Console.WriteLine("Its a banana");
                }
            }

        }
    }
}
