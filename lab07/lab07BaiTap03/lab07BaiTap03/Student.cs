using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07BaiTap03
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private double theoryMark;
        private double largeMark;
        public double TheoryMark {
            get => theoryMark;
            set
            {
                if (value < 0 || value > 10)
                {
                    // Tung exception với đúng các tham số bạn đã định nghĩa
                    throw new InvalidMarkException(
                        message: $"Điểm lý thuyết ({value}) phải nằm trong khoảng 0-10!",
                        isValid: "False",
                        status: "Invalid Theory Mark"
                    );
                }
                theoryMark = value;
            }

        }
        public double LargeMark { get => largeMark; set {
                if (value < 0 || value > 10)
                {
                    throw new InvalidMarkException(
                        message: $"Điểm thực hành ({value}) phải nằm trong khoảng 0-10!",
                        isValid: "False",
                        status: "Invalid Large Mark"
                    );
                }
                largeMark = value;


            } }
        public Student(int id, string name, double theoryMark, double largeMark)
        {
            Id = id;
            Name = name;
            TheoryMark = theoryMark;
            LargeMark = largeMark;
        }
        public Student() { }

        public string GetStudentInfo()
        {
            return $"ID: {Id}, Name: {Name}, Theory Mark: {TheoryMark}, Large Mark: {LargeMark}";
        }
    }
}
