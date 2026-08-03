using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04Bai3
{
    abstract class Shape
    {
        public float radius, length, width;
        // tính diện tích
        public abstract float Area();
        // tính chu vi
        public abstract float Circomference();



    }
}
