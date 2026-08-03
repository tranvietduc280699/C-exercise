using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04Bai4
{
    internal class Staff : Iperson
    {
        public void Delete(object obj)
        {
            Console.WriteLine("xóa đối tượng");
        }

        public void Display(object obj)
        {
            Console.WriteLine("thông tin đối tượng");
        }

        public void Insert(object obj)
        {
            Console.WriteLine("thêm mới đối tượng");
        }

        public void Update(object obj)
        {
            Console.WriteLine("cập nhật đối tượng");
        }
    }
}
