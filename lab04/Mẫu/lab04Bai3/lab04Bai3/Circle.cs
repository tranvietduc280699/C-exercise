using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04Bai3
{
    internal class Circle: Shape
    {
        public void InputData()
        {
            Console.WriteLine("Nhập bán kính:");
            radius = int.Parse(Console.ReadLine());
        }
        // ghi đè phương thức tính diện tích
        public override float Area()
        {
            return 3.14F * radius * radius;
        }
        // ghi đè phương thức tính chu vi
        public override float Circomference()
        {
            return 2 * 3.14F * radius;
        }
    }
}
