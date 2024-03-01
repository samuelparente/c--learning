using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes
{
    public class Car
    {
        private string Brand;
        private string Color;
        private int Speed;

        //Property
        public string brand
        {
            get { return Brand; }   // get method
            set { Brand = value; }  // set method
        }

        //Property
        public string color
        {
            get { return Color; }   // get method
            set { Color = value; }  // set method
        }

        //Property
        public int speed
        {
            get { return Speed; }   // get method
            set { Speed = value; }  // set method
        }

        //Methods
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can.");
        }

        public void fullBrakes()
        {
            Console.WriteLine("The car is trying to apply full brakes.");
        }

    }
}
