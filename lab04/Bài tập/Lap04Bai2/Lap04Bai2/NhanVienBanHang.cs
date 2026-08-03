using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap04Bai2
{
    internal class NhanVienBanHang : NhanVien
    {
        public float soLuongBanDuoc;
        public NhanVienBanHang(float soLuongBanDuoc)
        {
            this.soLuongBanDuoc = soLuongBanDuoc;
        }
        public override void HienThi()
        {
            Console.WriteLine("Đây là hàm hiển thị");
        }

        public override float TinhLuong()
        {
            return soLuongBanDuoc * soLuongBanDuoc;

        }
    }
}
