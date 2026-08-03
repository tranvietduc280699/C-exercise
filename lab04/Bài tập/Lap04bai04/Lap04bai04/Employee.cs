using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap04bai04
{
    public abstract class Employee : Person
    {
        // phòng ban
        public string department { get; set; }
        // lương
        public double salary { get; set; }   
        // ngày tuyển dụng
        public DateTime dateHired { get; set; }

        public abstract double CalculateBonus();
        public abstract int CalculateVacation();
       
    }
}
