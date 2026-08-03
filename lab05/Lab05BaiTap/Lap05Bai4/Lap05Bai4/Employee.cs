using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap05Bai4
{
    internal class Employee
    {
        public string id { get; set; }
        public string name {  get; set; }

        public int age { get; set; }
        // constructor
        public Employee() { }
        public Employee(string id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        // Phương thức hiển thị
        public string ShowInfo()
        {
            return $"ID: {id}" + ", " +
                $"Name: {name}" + ", " +
                $"Age: {age}";
        }
    }
}
