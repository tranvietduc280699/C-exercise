using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Car
    {
        private static int id = 0;
        public string make;
        public string model;
        public string color;
        public string year;

        // constructor
        public Car() { }
        public Car( string make, string model, string color, string year)
        {
            this.make = make;
            this.model = model;
            this.color = color;
            this.year = year;
        }

        // khởi tạo một phương thức start
        public void Start()
        {
            Console.WriteLine($"Car {make} {model} ({color}, {year}) is starting.");
        }
        // khởi tạo một phương thức stop
        public void Stop()
        {
            Console.WriteLine($"Car {make} {model} ({color}, {year}) is stop.");
        }
    }
}
