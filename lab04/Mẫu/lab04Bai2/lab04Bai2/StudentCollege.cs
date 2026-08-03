using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04Bai2
{
    internal class StudentCollege : Student
    {
        protected double score1,score2,score3;
        // constructor
       public StudentCollege()
        {

        }
        public StudentCollege(string name, int year,double score1, double score2, double score3) 
            : base(name, year)
        {
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
        }

        // ghi đè phương thức tính trung bình điểm
        public override double Average()
        {
            return (score1 + score2 + score3) / 3;
        }

        // hiển thị thông tin
        public void showScore()
        {
            base.Display();
            Console.WriteLine($"{score1} {score2} {score3}");
        }
    }
}
