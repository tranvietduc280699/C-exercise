using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04Bai3
{
    internal class Rectangle : Shape
    {
        public void InputData()
        {
            Console.WriteLine("Nhập chiều dài:");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chiều rộng:");
            width = int.Parse(Console.ReadLine());
        }
        // tính diện tích
        public override float Area()
        {
            return length * width;
        }

        public override float Circomference()
        {
            return 2 * length * width;
        }
    }
}
