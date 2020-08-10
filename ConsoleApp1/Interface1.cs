using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1
{
    interface IVehicle
    {
        string Location 
        { 
            get;
        }
        int NumberOfSeats 
        { 
            get;
        }
        void MoveTo (string City);
    }

    class Car : IVehicle
    {
        //constructor
        public Car(String carLocation, int noOfSeats)
        {
            Location = carLocation;
            NumberOfSeats = 5;
        }
        public int NumberOfSeats
        {
            get;
            set;
        }
        // MoveTo('Luxembourg') changes Location property


        public string Location
        {
            get;
            set;
        }
        public void MoveTo(string City)
        {
            this.Location = City;
        }

    }
}
