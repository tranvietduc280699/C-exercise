using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_list
{
    public class Student
    {
        //
        private int Id = 0;
        public string Name { get; set; }
        public int Age { get; set; }

        public string Address { get; set; }
        public Student( string Name, int Age, string Address)
        {
            this.Id++;
            this.Name = Name;
            this.Age = Age;
            this.Address = Address;
        }
        // hiển thị
        public void GetInfo()
        {
            Console.WriteLine($"Id: {Name}");
            Console.WriteLine($"Id: {Age}");
            Console.WriteLine($"Id: {Address}");
        }

    }
}
