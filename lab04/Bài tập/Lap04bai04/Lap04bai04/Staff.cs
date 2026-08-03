using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap04bai04
{
    internal class Staff: Employee
    {
        // chức danh công việc
        public string rankInfo {  get; set; }

        public override double CalculateBonus()
        {
            return 0.06 * salary;
        }

        public override int CalculateVacation()
        {
            int yearWorked = DateTime.Now.Year - dateHired.Year;

            if (yearWorked >= 5)
            {
                return 4;
            }
            else
            {
                return 3;
            }
        }
    }
}
