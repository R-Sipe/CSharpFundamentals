using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum VehicleType { Car, Truck, Van, Motorcycle, Plane, Boat, Scooter}
    public class Vehicle
    {
        public Vehicle(string make, string model, double milage, VehicleType typeOfVehicle)
        {
                Make = make;
                Model = model;
                Milage = milage;
                TypeOfVehicle = typeOfVehicle;
        }

        public Vehicle() { }

        //1 Access Modifier
        //2 Type - type the property can hold
        //3 Name 
        //4 Getters and setters

        //1      2     3         4
        public string Make { get; set; }
        public string Model { get; set; }
        public double Milage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public bool IsRunning { get; private set; }

        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("You turned on the vehicle");
        }

        public void TurnOff()
        {
            IsRunning = false;
            Console.WriteLine("You turned off the vehicle");
        }

        public bool RightIndicator { get; private set; }
        public bool LeftIndicator { get; private set; }

        public void IndicateRight()
        {
            RightIndicator = true;
            LeftIndicator = false;
        }

        public void IndicateLeft()
        {
            LeftIndicator = true;
            RightIndicator = false;
        }

        public void TurnOnHazards()
        {
            LeftIndicator = true;
            RightIndicator = true;
        }

        public void TurnOffHazards()
        {
            LeftIndicator = false;
            RightIndicator = false;
        }

        //Challenge
        //1 Make indicator its own class
        //2 propewrties including IsFlashing 
        //3 Method for TurnOn() and TurnOff()
        // 4 - methods would set value of IsFlashing
    }

    public class Indicator //1
    {
        public bool isFlashing { get; private set; } //2 property isflashing

        public void TurnOn() //3
        {
            isFlashing = true; //4 
        }

        public void TurnOff() //3
        {
            isFlashing = false; //4
        }
    }
    
}
