using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Greeter
    {
        //1 Access modifier
        //2 Return type
        //3 Method signature - includes the method name and any parameters
        //4 Body of the method - code that gets executed when the method is called

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        public void SaySomething(string speech)
        {
            Console.WriteLine(speech);
        }

        public string GetRandomGreeting()
        {
            Random randy = new Random();
            string[] greetings = new string[] { "Hello", "hi", "Sup", "Yo", "Hey" };
            int randomNumber = randy.Next(0, greetings.Length);
            string greeting = greetings[randomNumber];
            return greeting;
        }
    }
}
