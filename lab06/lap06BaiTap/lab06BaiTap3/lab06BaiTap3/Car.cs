using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06BaiTap3
{
    public class Car
    {
        public string name {  get; set; }

        public string color { get; set; }
        public Car() { }
        public Car(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
    }
}
