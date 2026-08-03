using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03B01
{
    public class EmployeeModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int yearOfBirth { get; set; }
        public double salaryLevel { get; set; }
        public double basicSalary { get; set; }
        public EmployeeModel() { }
        public EmployeeModel(int id, string name, int yearOfBirth, double salaryLevel, double basicSalary)
        {
            this.id = id;
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.salaryLevel = salaryLevel;
            this.basicSalary = basicSalary;
        }
        // Trả về thu nhập
        public double GetIncome()
        {
            return salaryLevel * basicSalary;
        }

        // Hiển thị thông tin
        public void Display()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Tên: {name}");
            Console.WriteLine($"Năm sinh: {yearOfBirth}");
            Console.WriteLine($"Lương cơ bản: {basicSalary}");
            Console.WriteLine($"Thu nhập: {GetIncome()}");
        }
    }
  
}
