using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04Bai2
{
    abstract class Student
    {
        protected string name { get; set; }
        protected int year { get; set; }
       public Student()
        {

        }
        public Student(string name, int year)
        {
            this.name = name;
            this.year = year;   
        }
        public void Display()
        {
            Console.WriteLine($"Tên: {name}");
            Console.WriteLine($"Năm: {year}");

        }
        // tính điểm trung bình
        public abstract double Average();
    }
}
