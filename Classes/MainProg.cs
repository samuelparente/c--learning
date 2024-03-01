//Samuel Parente - C# programming exercises

using System;

namespace Classes
{
    internal class MainProg
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.color = "Red";
            myCar.brand = "Ferrari";
            myCar.speed = 250;

            Console.WriteLine(myCar.color);
            Console.WriteLine(myCar.brand); 
            Console.WriteLine(myCar.speed + "km/h"); 

            myCar.fullThrottle();
            myCar.fullBrakes();
        }
    }

}
