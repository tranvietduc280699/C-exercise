using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap04Bai2
{
    abstract class NhanVien
    {
        public string ten { get; set; }
        public string diaChi { get; set; }
      

        public abstract float TinhLuong();

        public abstract void HienThi();
    }
}
