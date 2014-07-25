using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    class Car
    {
        private string make;
        private string model;
        private string color;


        public string Make 
        {
            get { return this.make; }
            set { this.make = value; }

        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }

        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }

        }

        public void Drive()
        {
            Console.WriteLine();
            Console.WriteLine("The car is Driving ");
        }

        public void Stop()
        {
            Console.WriteLine();
            Console.WriteLine("The car is Stopping ");
        }

        public void DisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Car Details");
            Console.WriteLine("Make: "+ this.make);
            Console.WriteLine("Model: " + this.model);
            Console.WriteLine("Color: " + this.color);
        }

    }
}
