using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruit
{
    public class Banana : IFruit
    {
        //Consotructors
        public Banana() { }
        public Banana(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }
        public string Name
        {
            get
            {
                return "Banana";
            }
        }

        public bool IsPeeled { get; private set; }

        public string Peel()
        {
            IsPeeled = true;
            return "POGGERS you peeled the banana";
        }

    }

    public class Orange : IFruit
    {
        //Constructors
        public Orange() { }
        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        public string Name
        {
            get
            {
                return "Orange";
            }
        }

        public bool IsPeeled { get; private set; }

        //Use the same interface method but bodies can be different as long as the return tpye matches
        public string Peel()
        {
            if (IsPeeled)
            {
                return "It is already peeled";
            }
            else
            {
                IsPeeled = true;
                return "You peeled the orange";
            }
        }
        
        //Classes that use interfaces can still have unique properties and methods.
        public string Squeeze()
        {
            return "You squeezed the orange and it spilled everywhere";
        }
    }

    public class Grape : IFruit
    {
        public string Name
        {
            get
            {
                return "Grape";
            }
        }
        //Harsetting property as false
        public bool IsPeeled { get; } = false;

        public string Peel()
        {
            return "Nice meme, loser. No one peels grapes.";
        }
    }

    //Make an Apple class iinheriting from IFruit
    public class Apple : IFruit
    {

        public string Name => "Apple";

        public bool IsPeeled { get; private set; }

            public string Peel()
        {
            if (IsPeeled)
            {
               return "Ready for the pie";
            }
            else
            {
                IsPeeled = true;
                return "You peeled the apple";
            }
        }
    }
}
