using System;
namespace lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bài 1:
            Car car = new Car("XE" ,"MOTO","Vàng", "2019");
            car.Start();
            car.Stop();
        }
    }
}
