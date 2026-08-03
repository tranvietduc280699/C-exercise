using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap04bai04
{
    public class Faculty: Employee
    {
        // giờ làm việc
        public DateTime OfficeHours {  get; set; }
        // chức danh
        public string rank { get; set; }

        public override double CalculateBonus()
        {
            return 1000 + 0.05 * salary;
        }

        public override int CalculateVacation()
        {
            // tính số năm làm được
            int yearWorked = DateTime.Now.Year - dateHired.Year;
            int week = 1;
            if (yearWorked > 3)
            {
                week = 5;
                if (rank == "Senior Lecturer")
                {
                    week++;
                }
            }
            else
            {
                week = 4;
            }
            return week;
        }
    }
}
