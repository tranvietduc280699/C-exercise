using System;

namespace lab07BaiTap04
{
    internal class Lecture
    {
        public string Name { get; set; }

        private double salary;
        private double bonus;

        public double Salary
        {
            get => salary;
            set
            {
                if (value < 60000)
                {
                    throw new AmountException(
                        message: $"Lương ({value:N0}$) không được thấp hơn 60,000$!",
                        isValid: "False",
                        status: "Invalid Salary"
                    );
                }
                salary = value;
            }
        }

        public double Bonus
        {
            get => bonus;
            set
            {
                if (value > 10000)
                {
                    throw new AmountException(
                        message: $"Thưởng ({value:N0}$) không được vượt quá 10,000$!",
                        isValid: "False",
                        status: "Invalid Bonus"
                    );
                }
                bonus = value;
            }
        }

        public Lecture() { }

        public Lecture(string name, double salary, double bonus)
        {
            Name = name;
            Salary = salary;
            Bonus = bonus;   
        }

        public string GetLectureInfo()
        {
            return $"Tên: {Name}, Lương: {Salary:N0}$, Thưởng: {Bonus:N0}$";
        }
    }
}