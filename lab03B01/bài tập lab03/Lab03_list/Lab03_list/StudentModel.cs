using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_list
{
    internal class StudentModel
    {
        // khai báo danh sách sinh viên
        List<Student> listStudent;
        public StudentModel()
        {
            this.listStudent = new List<Student>()
            {
                new Student("TVD",23,"Cổ nhuế"),
                new Student("abc",20,"Hà đông"),
                new Student("hhtp",20,"HHP"),
            };
            
        }
    }
}
